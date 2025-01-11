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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string kullaniciAdi = txt_GiriskAdi.Text;
            string sifre = txt_GirisSifre.Text;

            string kayitliKullaniciAdi = "Admin";
            string kayitliSifre = "1907";

            if(kullaniciAdi == kayitliKullaniciAdi && sifre == kayitliSifre)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız Admin.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1 form = new Form1();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Başarısız Giriş Yaptınız .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    
        }
    }
}
