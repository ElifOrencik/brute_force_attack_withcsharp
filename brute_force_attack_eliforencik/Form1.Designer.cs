namespace brute_force_attack_eliforencik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPasswordList = new TextBox();
            minkrktr_txt = new TextBox();
            maxkrktr_txt = new TextBox();
            set_txt = new TextBox();
            btnOlustur = new Button();
            btnSelectPasswordList = new Button();
            btnStartAttack = new Button();
            richTextBoxLogs = new RichTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            txt_saldiri = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(207, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPasswordList
            // 
            txtPasswordList.Location = new Point(207, 156);
            txtPasswordList.Name = "txtPasswordList";
            txtPasswordList.Size = new Size(189, 27);
            txtPasswordList.TabIndex = 2;
            // 
            // minkrktr_txt
            // 
            minkrktr_txt.Location = new Point(288, 66);
            minkrktr_txt.Name = "minkrktr_txt";
            minkrktr_txt.Size = new Size(225, 27);
            minkrktr_txt.TabIndex = 3;
            // 
            // maxkrktr_txt
            // 
            maxkrktr_txt.Location = new Point(288, 142);
            maxkrktr_txt.Name = "maxkrktr_txt";
            maxkrktr_txt.Size = new Size(225, 27);
            maxkrktr_txt.TabIndex = 4;
            // 
            // set_txt
            // 
            set_txt.Location = new Point(288, 217);
            set_txt.Name = "set_txt";
            set_txt.Size = new Size(225, 27);
            set_txt.TabIndex = 5;
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.FromArgb(0, 0, 64);
            btnOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOlustur.ForeColor = SystemColors.ButtonFace;
            btnOlustur.Location = new Point(156, 372);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(333, 64);
            btnOlustur.TabIndex = 6;
            btnOlustur.Text = "Şifre Listesi Oluştur";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // btnSelectPasswordList
            // 
            btnSelectPasswordList.BackColor = Color.FromArgb(0, 0, 64);
            btnSelectPasswordList.ForeColor = SystemColors.ButtonHighlight;
            btnSelectPasswordList.Location = new Point(403, 113);
            btnSelectPasswordList.Name = "btnSelectPasswordList";
            btnSelectPasswordList.Size = new Size(109, 57);
            btnSelectPasswordList.TabIndex = 7;
            btnSelectPasswordList.Text = "Wordlist Seç";
            btnSelectPasswordList.UseVisualStyleBackColor = false;
            btnSelectPasswordList.Click += btnSelectPasswordList_Click;
            // 
            // btnStartAttack
            // 
            btnStartAttack.BackColor = Color.FromArgb(0, 0, 64);
            btnStartAttack.ForeColor = SystemColors.ButtonFace;
            btnStartAttack.Location = new Point(141, 493);
            btnStartAttack.Name = "btnStartAttack";
            btnStartAttack.Size = new Size(365, 53);
            btnStartAttack.TabIndex = 8;
            btnStartAttack.Text = "Saldırı Gerçekleştir";
            btnStartAttack.UseVisualStyleBackColor = false;
            btnStartAttack.Click += btnStartAttack_ClickAsync;
            // 
            // richTextBoxLogs
            // 
            richTextBoxLogs.BackColor = SystemColors.InactiveBorder;
            richTextBoxLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxLogs.Location = new Point(50, 232);
            richTextBoxLogs.Name = "richTextBoxLogs";
            richTextBoxLogs.Size = new Size(517, 246);
            richTextBoxLogs.TabIndex = 9;
            richTextBoxLogs.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(618, 666);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(btnOlustur);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(610, 633);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Şifre Listesi Oluşturma";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(418, 548);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 77);
            panel4.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Red;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 4.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(10, 11);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 58);
            textBox2.TabIndex = 17;
            textBox2.Text = "!!! BU UYGULAMA ÖĞRENME AMACIYLA YAPILMIŞ OLUP SUÇ TEŞKİL EDİLEN DURUMLARDA HERHANGİ BİR SORUMLULUK KABUL EDİLMEMEKTEDİR.";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(minkrktr_txt);
            panel1.Controls.Add(maxkrktr_txt);
            panel1.Controls.Add(set_txt);
            panel1.Location = new Point(42, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 318);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 216);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 9;
            label3.Text = "Bulunan Karakterler:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 141);
            label2.Name = "label2";
            label2.Size = new Size(268, 28);
            label2.TabIndex = 8;
            label2.Text = "Maksimum Karakter Sayısı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 66);
            label1.Name = "label1";
            label1.Size = new Size(255, 28);
            label1.TabIndex = 7;
            label1.Text = "Minimum Karakter Sayısı:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(richTextBoxLogs);
            tabPage2.Controls.Add(btnStartAttack);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(610, 633);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Saldırı Gerçekleştirme";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 572);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(430, 558);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 77);
            panel3.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 4.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 11);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 58);
            textBox1.TabIndex = 17;
            textBox1.Text = "!!! BU UYGULAMA ÖĞRENME AMACIYLA YAPILMIŞ OLUP SUÇ TEŞKİL EDİLEN DURUMLARDA HERHANGİ BİR SORUMLULUK KABUL EDİLMEMEKTEDİR.";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_saldiri);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtPasswordList);
            panel2.Controls.Add(btnSelectPasswordList);
            panel2.Location = new Point(50, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 196);
            panel2.TabIndex = 15;
            // 
            // txt_saldiri
            // 
            txt_saldiri.BackColor = SystemColors.ScrollBar;
            txt_saldiri.Location = new Point(130, 30);
            txt_saldiri.Multiline = true;
            txt_saldiri.Name = "txt_saldiri";
            txt_saldiri.Size = new Size(266, 35);
            txt_saldiri.TabIndex = 14;
            txt_saldiri.Text = "http://testasp.vulnweb.com/Login.asp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, -1);
            label6.Name = "label6";
            label6.Size = new Size(355, 28);
            label6.TabIndex = 13;
            label6.Text = "Saldırı Yapılan Deneme Sitesi URL'si:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 101);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 11;
            label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 155);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 10;
            label4.Text = "Seçili Wordlist:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(643, 690);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "KABA KUVVET SALDIRI GERÇEKLEŞTİRME";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPasswordList;
        private TextBox minkrktr_txt;
        private TextBox maxkrktr_txt;
        private TextBox set_txt;
        private Button btnOlustur;
        private Button btnSelectPasswordList;
        private Button btnStartAttack;
        private RichTextBox richTextBoxLogs;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_saldiri;
        private Panel panel2;
        private TextBox textBox1;
        private Label label7;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox2;
    }
}