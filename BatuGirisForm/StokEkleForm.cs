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
    public partial class StokEkleForm : Form
    {
        public StokEkleForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan veriler
            string urunKodu = txtUrunKodu.Text;
            string urunAdi = txtUrunAdi.Text;
            int urunAdedi = int.Parse(txtUrunAdedi.Text);
            decimal urunAlisFiyati = decimal.Parse(txtUrunAlisFiyati.Text);
            decimal urunSatisFiyati = decimal.Parse(txtSatisFiyati.Text);

            // Veritabanına bağlantı ve stok ekleme işlemi
            string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Trusted_Connection=True;";
            //  string connectionString = "Server=BATUHAN\\;Database=uniProje;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Stok (UrunKodu, UrunAdi, UrunAdedi, UrunAlisFiyati, satisFiyati)" +
                                   " VALUES (@UrunKodu, @UrunAdi, @UrunAdedi, @UrunAlisFiyati, @satisFiyati)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UrunKodu", urunKodu);
                        command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        command.Parameters.AddWithValue("@UrunAdedi", urunAdedi);
                        command.Parameters.AddWithValue("@UrunAlisFiyati", urunAlisFiyati);
                        command.Parameters.AddWithValue("@satisFiyati", urunSatisFiyati);

                        command.ExecuteNonQuery();  // Veriyi veritabanına ekler
                    }
                    MessageBox.Show("Stok başarıyla eklendi!");

                    // **StoklarForm**'u bulup, güncelleme yapıyoruz
                    StoklarForm stoklarForm = Application.OpenForms.OfType<StoklarForm>().FirstOrDefault();
                    if (stoklarForm != null)
                    {
                        stoklarForm.GuncelleDataGrid();  // Veri güncelleniyor
                    }

                    // Formu kapatıyoruz, stok ekleme tamamlandıktan sonra.
                    this.Close();  // Stok ekleme formunu kapatıyoruz
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);  // Hata mesajını göster
                }
            }
        }


    }
}
