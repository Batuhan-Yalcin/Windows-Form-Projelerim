using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatuGirisForm
{
    public partial class StoklarForm: Form
    {
        public StoklarForm ()
        {
            InitializeComponent();
        }

        private void StokFormdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StoklarForm_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını ve veri çekmeyi burada yapacağız
            string connectionString = "Server=BATUHAN\\;Database=uniProje;Trusted_Connection=True;";
            string query = "SELECT UrunKodu, UrunAdi, UrunAdedi, UrunAlisFiyati, satisFiyati FROM Stok";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);  // Veritabanından veri çekiliyor

                // DataGridView kolonlarını manuel olarak ekliyoruz
                StokFormdata.Columns.Clear();  // Önce var olan kolonları temizliyoruz
                StokFormdata.Columns.Add("UrunKodu", "Ürün Kodu");
                StokFormdata.Columns.Add("UrunAdi", "Ürün Adı");
                StokFormdata.Columns.Add("UrunAdedi", "Ürün Adedi");
                StokFormdata.Columns.Add("UrunAlisFiyati", "Alış Fiyatı");
                StokFormdata.Columns.Add("SatisFiyati", "Satış Fiyatı");

                // Veriyi DataGridView'e bağlama
                StokFormdata.DataSource = dataTable;  // DataTable verisini DataGridView'e atıyoruz
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Veri tabanında veri bulunamadı.");
                }
            }
        }




        public void GuncelleDataGrid()
        {
            string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Trusted_Connection=True;";
            // string connectionString = "Server=BATUHAN\\;Database=uniProje;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = "SELECT UrunKodu, UrunAdi, UrunAdedi, UrunAlisFiyati, satisFiyati FROM Stok";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Veriyi DataGridView'e bağlama
                StokFormdata.DataSource = dataTable;
            }
        }



    }
}
