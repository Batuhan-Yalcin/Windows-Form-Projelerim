namespace GirişSistemiProjesi
{
    partial class GirisFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kAdi = new System.Windows.Forms.Label();
            this.txt_GiriskAdi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_GirisSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kAdi
            // 
            this.lbl_kAdi.AutoSize = true;
            this.lbl_kAdi.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_kAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kAdi.Location = new System.Drawing.Point(21, 33);
            this.lbl_kAdi.Name = "lbl_kAdi";
            this.lbl_kAdi.Size = new System.Drawing.Size(173, 17);
            this.lbl_kAdi.TabIndex = 0;
            this.lbl_kAdi.Text = "Kullanıcı adını giriniz : ";
            // 
            // txt_GiriskAdi
            // 
            this.txt_GiriskAdi.ForeColor = System.Drawing.Color.Black;
            this.txt_GiriskAdi.Location = new System.Drawing.Point(200, 33);
            this.txt_GiriskAdi.Name = "txt_GiriskAdi";
            this.txt_GiriskAdi.Size = new System.Drawing.Size(147, 20);
            this.txt_GiriskAdi.TabIndex = 0;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(21, 85);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(134, 17);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "Şifrenizi Giriniz : ";
            // 
            // txt_GirisSifre
            // 
            this.txt_GirisSifre.ForeColor = System.Drawing.Color.Black;
            this.txt_GirisSifre.Location = new System.Drawing.Point(200, 85);
            this.txt_GirisSifre.Name = "txt_GirisSifre";
            this.txt_GirisSifre.Size = new System.Drawing.Size(147, 20);
            this.txt_GirisSifre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(24, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_GirisSifre);
            this.Controls.Add(this.txt_GiriskAdi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kAdi;
        private System.Windows.Forms.TextBox txt_GiriskAdi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_GirisSifre;
        private System.Windows.Forms.Button button1;
    }
}