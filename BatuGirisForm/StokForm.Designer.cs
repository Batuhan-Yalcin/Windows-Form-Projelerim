namespace BatuGirisForm
{
    partial class StokForm
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
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnStoklar = new System.Windows.Forms.Button();
            this.btnStokGuncelle = new System.Windows.Forms.Button();
            this.btnUygulamayiKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.Location = new System.Drawing.Point(-1, 1);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(151, 78);
            this.btnStokEkle.TabIndex = 0;
            this.btnStokEkle.Text = "STOK EKLE";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnStoklar
            // 
            this.btnStoklar.BackColor = System.Drawing.Color.Yellow;
            this.btnStoklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoklar.Location = new System.Drawing.Point(182, 1);
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.Size = new System.Drawing.Size(151, 78);
            this.btnStoklar.TabIndex = 0;
            this.btnStoklar.Text = "STOKLAR";
            this.btnStoklar.UseVisualStyleBackColor = false;
            this.btnStoklar.Click += new System.EventHandler(this.btnStoklar_Click);
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStokGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokGuncelle.Location = new System.Drawing.Point(-1, 105);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(151, 78);
            this.btnStokGuncelle.TabIndex = 0;
            this.btnStokGuncelle.Text = "STOK GÜNCELLE";
            this.btnStokGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnUygulamayiKapat
            // 
            this.btnUygulamayiKapat.BackColor = System.Drawing.Color.Red;
            this.btnUygulamayiKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUygulamayiKapat.Location = new System.Drawing.Point(182, 105);
            this.btnUygulamayiKapat.Name = "btnUygulamayiKapat";
            this.btnUygulamayiKapat.Size = new System.Drawing.Size(151, 78);
            this.btnUygulamayiKapat.TabIndex = 0;
            this.btnUygulamayiKapat.Text = "UYGULAMAYI KAPAT";
            this.btnUygulamayiKapat.UseVisualStyleBackColor = false;
            this.btnUygulamayiKapat.Click += new System.EventHandler(this.btnUygulamayiKapat_Click);
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 192);
            this.Controls.Add(this.btnUygulamayiKapat);
            this.Controls.Add(this.btnStokGuncelle);
            this.Controls.Add(this.btnStoklar);
            this.Controls.Add(this.btnStokEkle);
            this.Name = "StokForm";
            this.Text = "StokForm";
            this.Load += new System.EventHandler(this.StokForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnStoklar;
        private System.Windows.Forms.Button btnStokGuncelle;
        private System.Windows.Forms.Button btnUygulamayiKapat;
    }
}