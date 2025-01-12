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
            this.components = new System.ComponentModel.Container();
            this.StokFormdata = new System.Windows.Forms.DataGridView();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniProjeDataSet = new BatuGirisForm.uniProjeDataSet();
            this.stokTableAdapter = new BatuGirisForm.uniProjeDataSetTableAdapters.StokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StokFormdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniProjeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StokFormdata
            // 
            this.StokFormdata.AutoGenerateColumns = false;
            this.StokFormdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StokFormdata.DataSource = this.stokBindingSource;
            this.StokFormdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StokFormdata.Location = new System.Drawing.Point(0, 0);
            this.StokFormdata.Name = "StokFormdata";
            this.StokFormdata.Size = new System.Drawing.Size(546, 452);
            this.StokFormdata.TabIndex = 0;
            this.StokFormdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StokFormdata_CellContentClick);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "Stok";
            this.stokBindingSource.DataSource = this.uniProjeDataSet;
            // 
            // uniProjeDataSet
            // 
            this.uniProjeDataSet.DataSetName = "uniProjeDataSet";
            this.uniProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniProjeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StokFormdata;
        private uniProjeDataSet uniProjeDataSet;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private uniProjeDataSetTableAdapters.StokTableAdapter stokTableAdapter;
    }
}