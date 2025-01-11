namespace SinavaEkPuanProjeBatu
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
            this.label5 = new System.Windows.Forms.Label();
            this.kayitAdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kayitKadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kayitSifre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kayitEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.giriskAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.girissSifre = new System.Windows.Forms.TextBox();
            this.btnkayit = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad Soyad :";
            // 
            // kayitAdSoyad
            // 
            this.kayitAdSoyad.Location = new System.Drawing.Point(92, 25);
            this.kayitAdSoyad.Name = "kayitAdSoyad";
            this.kayitAdSoyad.Size = new System.Drawing.Size(171, 20);
            this.kayitAdSoyad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kullanıcı Adı :";
            // 
            // kayitKadi
            // 
            this.kayitKadi.Location = new System.Drawing.Point(92, 64);
            this.kayitKadi.Name = "kayitKadi";
            this.kayitKadi.Size = new System.Drawing.Size(171, 20);
            this.kayitKadi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şifre : ";
            // 
            // kayitSifre
            // 
            this.kayitSifre.Location = new System.Drawing.Point(92, 105);
            this.kayitSifre.Name = "kayitSifre";
            this.kayitSifre.Size = new System.Drawing.Size(171, 20);
            this.kayitSifre.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email : ";
            // 
            // kayitEmail
            // 
            this.kayitEmail.Location = new System.Drawing.Point(92, 147);
            this.kayitEmail.Name = "kayitEmail";
            this.kayitEmail.Size = new System.Drawing.Size(171, 20);
            this.kayitEmail.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cinsiyet : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kullanıcı adı :";
            // 
            // giriskAd
            // 
            this.giriskAd.Location = new System.Drawing.Point(490, 25);
            this.giriskAd.Name = "giriskAd";
            this.giriskAd.Size = new System.Drawing.Size(171, 20);
            this.giriskAd.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Şifre : ";
            // 
            // girissSifre
            // 
            this.girissSifre.Location = new System.Drawing.Point(490, 93);
            this.girissSifre.Name = "girissSifre";
            this.girissSifre.Size = new System.Drawing.Size(171, 20);
            this.girissSifre.TabIndex = 1;
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(6, 233);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(257, 23);
            this.btnkayit.TabIndex = 2;
            this.btnkayit.Text = "Kayıt Ol";
            this.btnkayit.UseVisualStyleBackColor = true;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(404, 154);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(257, 23);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Location = new System.Drawing.Point(92, 195);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(53, 17);
            this.radioErkek.TabIndex = 3;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(178, 195);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(52, 17);
            this.radioKadin.TabIndex = 3;
            this.radioKadin.TabStop = true;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(730, 395);
            this.Controls.Add(this.radioKadin);
            this.Controls.Add(this.radioErkek);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kayitEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kayitSifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kayitKadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.girissSifre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.giriskAd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.kayitAdSoyad);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GirisKadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox girisSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.RadioButton rbtnErkek;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kayitAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kayitKadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kayitSifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kayitEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox giriskAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox girissSifre;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.RadioButton radioKadin;
    }
}

