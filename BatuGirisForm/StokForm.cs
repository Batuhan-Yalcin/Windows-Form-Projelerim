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
    public partial class StokForm : Form
    {
        // // string connectionString = "Server=BATUHAN\\;Database=uniProje;Trusted_Connection=True;TrustServerCertificate=True;
        string connectionString = "Server=BATUHAN\\SQLEXPRESS;Database=uniProje;Trusted_Connection=True;";

        public StokForm()
        {
            InitializeComponent();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            StokEkleForm stokEkleForm = new StokEkleForm();
            stokEkleForm.Show();  // Formu doğru şekilde açıyoruz
        }

        private void btnUygulamayiKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
          
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            StoklarForm stoklarForm = new StoklarForm();
            stoklarForm.Show();
        }
    }
    }
    

