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
    public partial class Form1 : Form
    {
        string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Trusted_Connection=True;";
        //   string connectionString = "Server=BATUHAN\\;Database=uniProje;Trusted_Connection=True;";




        public Form1()
        {
            InitializeComponent();
        }


       
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string email = txtEmail.Text;
            string cinsiyet = rbtnErkek.Checked ? "Erkek" : "Kadın";
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO KullaniciKayit (adSoyad, eposta, cinsiyet, kullaniciAdi, sifre) VALUES (@adSoyad, @eposta, @cinsiyet, @kullaniciAdi, @sifre)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@adSoyad", adSoyad);
                        command.Parameters.AddWithValue("@eposta", email);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarılı!");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız oldu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }



      
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdiGiris.Text;
            string sifre = txtSifreGiris.Text;

          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM KullaniciKayit WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");
                       
                        StokForm stokForm = new StokForm();
                        stokForm.Show(); 
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
                    }
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Label6 tıklandı!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Resimler\kayıtol.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
