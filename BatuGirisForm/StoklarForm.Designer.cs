namespace BatuGirisForm
{
    partial class StoklarForm
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
            this.StokFormdata = new System.Windows.Forms.DataGridView();
            this.urunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StokFormdata)).BeginInit();
            this.SuspendLayout();
            // 
            // StokFormdata
            // 
            this.StokFormdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StokFormdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKodu,
            this.UrunAdi,
            this.UrunAdedi,
            this.UrunAlisFiyati,
            this.satisFiyati});
            this.StokFormdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StokFormdata.Location = new System.Drawing.Point(0, 0);
            this.StokFormdata.Name = "StokFormdata";
            this.StokFormdata.Size = new System.Drawing.Size(546, 452);
            this.StokFormdata.TabIndex = 0;
            this.StokFormdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StokFormdata_CellContentClick);
            // 
            // urunKodu
            // 
            this.urunKodu.HeaderText = "ÜrünKodu";
            this.urunKodu.Name = "urunKodu";
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // UrunAdedi
            // 
            this.UrunAdedi.HeaderText = "Ürün Adedi";
            this.UrunAdedi.Name = "UrunAdedi";
            // 
            // UrunAlisFiyati
            // 
            this.UrunAlisFiyati.HeaderText = "Alış Fiyatı";
            this.UrunAlisFiyati.Name = "UrunAlisFiyati";
            // 
            // satisFiyati
            // 
            this.satisFiyati.HeaderText = "Satış Fiyatı";
            this.satisFiyati.Name = "satisFiyati";
            // 
            // StoklarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 452);
            this.Controls.Add(this.StokFormdata);
            this.Name = "StoklarForm";
            this.Text = "StoklarForm";
            this.Load += new System.EventHandler(this.StoklarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StokFormdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StokFormdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyati;
    }
}