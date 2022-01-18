
namespace clientside
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.giris_sifresi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.giris_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kayıt_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kayit_adi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lng = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.giris_sifresi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.giris_adi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 163);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "kayıt ol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // giris_sifresi
            // 
            this.giris_sifresi.Location = new System.Drawing.Point(135, 68);
            this.giris_sifresi.Name = "giris_sifresi";
            this.giris_sifresi.Size = new System.Drawing.Size(124, 20);
            this.giris_sifresi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "şifre";
            // 
            // giris_adi
            // 
            this.giris_adi.Location = new System.Drawing.Point(135, 37);
            this.giris_adi.Name = "giris_adi";
            this.giris_adi.Size = new System.Drawing.Size(124, 20);
            this.giris_adi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "kullanıcı adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "giriş yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ YAP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.kayıt_sifre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.kayit_adi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 166);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "giriş ekranı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "kayıt ol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kayıt_sifre
            // 
            this.kayıt_sifre.Location = new System.Drawing.Point(125, 76);
            this.kayıt_sifre.Name = "kayıt_sifre";
            this.kayıt_sifre.PasswordChar = '*';
            this.kayıt_sifre.Size = new System.Drawing.Size(124, 20);
            this.kayıt_sifre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "şifre";
            // 
            // kayit_adi
            // 
            this.kayit_adi.Location = new System.Drawing.Point(125, 47);
            this.kayit_adi.Name = "kayit_adi";
            this.kayit_adi.Size = new System.Drawing.Size(124, 20);
            this.kayit_adi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KAYIT EKRANI";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(91, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 169);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.lng);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lat);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(450, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 254);
            this.panel4.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(332, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 26);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(110, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "KONUM EKLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lng
            // 
            this.lng.Location = new System.Drawing.Point(110, 172);
            this.lng.Name = "lng";
            this.lng.Size = new System.Drawing.Size(176, 20);
            this.lng.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "lng";
            // 
            // lat
            // 
            this.lat.Location = new System.Drawing.Point(110, 108);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(176, 20);
            this.lat.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "lat";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(236, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "TESLİMAT ADRES EKRANI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.listBox1);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(106, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(680, 284);
            this.panel5.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "SİL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 108);
            this.listBox1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "TESLİMAT BİLGİLERİ";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(140, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(185, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "TESLİMAT ADRES EKRANI";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 599);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox kayıt_sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kayit_adi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox giris_sifresi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox giris_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox lng;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

