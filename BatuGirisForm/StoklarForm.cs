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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BatuGirisForm
{
    public partial class StoklarForm: Form
    {
        string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Trusted_Connection=True;";
        

        public StoklarForm ()
        {
            InitializeComponent();
        }

        private void StokFormdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void MusteriGetir()
        {
          SqlConnection  baglanti = new SqlConnection("server = .;Initial Catalog=uniProje;Integrated Security=SSPI");
            baglanti.Open();
          SqlDataAdapter  da = new SqlDataAdapter("SELECT * FROM Stok", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StokFormdata.DataSource = dt; 
            baglanti.Close();
        }

        private void StoklarForm_Load(object sender, EventArgs e)
        {
          
         
            this.stokTableAdapter.Fill(this.uniProjeDataSet.Stok);
            
            
            //  string connectionString = "Server=BATUHAN\\;Database=uniProje;Trusted_Connection=True;";
            string query = "SELECT UrunKodu, UrunAdi, UrunAdedi, UrunAlisFiyati, satisFiyati FROM Stok";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); 
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                StokFormdata.DataSource = bindingSource;
                /*
              
                StokFormdata.Columns.Clear();  
                StokFormdata.Columns.Add("UrunKodu", "Ürün Kodu");
                StokFormdata.Columns.Add("UrunAdi", "Ürün Adı");
                StokFormdata.Columns.Add("UrunAdedi", "Ürün Adedi");
                StokFormdata.Columns.Add("UrunAlisFiyati", "Alış Fiyatı");
                StokFormdata.Columns.Add("SatisFiyati", "Satış Fiyatı");
                */
             
                StokFormdata.AutoGenerateColumns = true; 

                StokFormdata.DataSource = null;
                StokFormdata.DataSource = dataTable;  
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

                
                StokFormdata.DataSource = dataTable;
            }
        }



    }
}
