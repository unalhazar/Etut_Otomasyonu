using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Etut_Automation
{
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Btn_GirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogretmenler where OgretmenTC=@p1 and OgretmenSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskdTc_No.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretmen_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgretmenEkrani fr = new OgretmenEkrani();
                fr.tc = mskdTc_No.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şfire");
                mskdTc_No.Focus();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
            mskdTc_No.Focus();
        }
    }
}
