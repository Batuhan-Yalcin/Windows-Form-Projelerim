using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SinavaEkPuanProjeBatu
{
    public partial class Form1 : Form
    {
        // Server adı ve database ismi
        string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde yapılacak işlemler
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }

        // Kullanıcı kaydı işlemi
        public void RegisterUser(string adSoyad, string eposta, string cinsiyet, string kullaniciAdi, string sifre)
        {
            string hashedPassword = HashPassword(sifre);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KullaniciKayit (adSoyad, eposta, cinsiyet, kullaniciAdi, sifre) " +
                               "VALUES (@adSoyad, @eposta, @cinsiyet, @kullaniciAdi, @sifre)";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Parametrelerin eklenmesi
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@eposta", eposta);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", hashedPassword);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        // Şifreyi hashleme fonksiyonu
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Kayıt ol butonuna tıklanma olayı
        private void btnkayit_Click(object sender, EventArgs e)
        {

            string adSoyad = kayitAdSoyad.Text;
            string kullaniciAdi = kayitKadi.Text;
            string eposta = kayitEmail.Text;
            string sifre = kayitSifre.Text;

            string cinsiyet = radioErkek.Checked ? "Erkek" : "Kadın";

            RegisterUser(adSoyad, eposta, cinsiyet, kullaniciAdi, sifre);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message);
                // Hata mesajını debug'da da yazdırabilirsiniz
                Console.WriteLine(ex.Message);
            }
        }

        // Giriş yap butonuna tıklanma olayı
        private void btngiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = giriskAd.Text;
            string sifre = girissSifre.Text;

            bool isValidUser = ValidateUser(kullaniciAdi, sifre);

            if (isValidUser)
            {
                MessageBox.Show("Giriş başarılı.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        // Kullanıcı doğrulama fonksiyonu
        private bool ValidateUser(string kullaniciAdi, string sifre)
        {
            string hashedPassword = HashPassword(sifre);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM KullaniciKayit WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", hashedPassword);

                try
                {
                    conn.Open();
                    int userCount = (int)cmd.ExecuteScalar();
                    return userCount > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Giriş sırasında bir hata oluştu: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
