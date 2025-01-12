using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BatuGirisForm
{
    public partial class StokGuncelleForm : Form
    {
        string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Trusted_Connection=True;";

        public StokGuncelleForm()
        {
            InitializeComponent();
        }

        private void StokGuncelleForm_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btnStokGetir_Click(object sender, EventArgs e)
        {
            string urunKodu = txtUrunKodu.Text;  

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UrunAdi, UrunAdedi, urunAlisFiyati, satisFiyati FROM Stok WHERE UrunKodu = @UrunKodu", con);
                cmd.Parameters.AddWithValue("@UrunKodu", urunKodu);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  
                {
                    txtUrunAdi.Text = reader["UrunAdi"].ToString();
                    txtUrunAdedi.Text = reader["UrunAdedi"].ToString();
                    txtAlisFiyati.Text = reader["urunAlisFiyati"].ToString();
                    txtSatisFiyati.Text = reader["satisFiyati"].ToString();
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }
        }

      
        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int urunKodu;
                if (int.TryParse(txtUrunKodu.Text, out urunKodu))  
                {
                    string urunAdi = txtUrunAdi.Text;
                    int urunAdedi;
                    decimal alisFiyati, satisFiyati;

                    
                    if (int.TryParse(txtUrunAdedi.Text, out urunAdedi) &&
                        decimal.TryParse(txtAlisFiyati.Text, out alisFiyati) &&
                        decimal.TryParse(txtSatisFiyati.Text, out satisFiyati))
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE Stok SET UrunAdi = @UrunAdi, UrunAdedi = @UrunAdedi, urunAlisFiyati = @urunAlisFiyati, satisFiyati = @satisFiyati WHERE UrunKodu = @UrunKodu", con);
                            cmd.Parameters.AddWithValue("@UrunKodu", urunKodu);
                            cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                            cmd.Parameters.AddWithValue("@UrunAdedi", urunAdedi);
                            cmd.Parameters.AddWithValue("@urunAlisFiyati", alisFiyati);
                            cmd.Parameters.AddWithValue("@satisFiyati", satisFiyati);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ürün başarıyla güncellendi.");
                            }
                            else
                            {
                                MessageBox.Show("Güncelleme başarısız.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz veriler geçerli değil.");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir ürün kodu girin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


       
        private void btnStokSil_Click(object sender, EventArgs e)
        {
            try
            {
                int urunKodu;
                if (int.TryParse(txtUrunKodu.Text, out urunKodu))  
                {
                    DialogResult dialogResult = MessageBox.Show("Bu ürünü silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Stok WHERE UrunKodu = @UrunKodu", con);
                            cmd.Parameters.AddWithValue("@UrunKodu", urunKodu);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ürün başarıyla silindi.");
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Silme başarısız.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir ürün kodu girin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        
        private void ClearFields()
        {
            txtUrunKodu.Clear();
            txtUrunAdi.Clear();
            txtUrunAdedi.Clear();
            txtAlisFiyati.Clear();
            txtSatisFiyati.Clear();
        }
    }
}
