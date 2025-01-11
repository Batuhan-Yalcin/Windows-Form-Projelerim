using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirişSistemiProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string email = txt_email.Text;
            string tel = txt_TelNo.Text;
            string sifre = txt_Sifre.Text;  
            string kAdi = txt_kAdi.Text;

           

            


            
            string KayittanGelenKullanici = "Admin";
            string kayitliSifre = "1907";

            if(kAdi == KayittanGelenKullanici && sifre == kayitliSifre)
            {
                MessageBox.Show("Kayıt Başarılı ! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisFormu giris = new GirisFormu();
                giris.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kayıt Başarısız ! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
