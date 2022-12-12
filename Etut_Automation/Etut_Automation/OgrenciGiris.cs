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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenciler where OgrenciNo=@p1 and OgrenciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtOgrenci_no.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrenci_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgrenciEkrani fr = new OgrenciEkrani();
                fr.no = TxtOgrenci_no.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı No & Şifre");
                TxtOgrenci_no.Focus();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            TxtOgrenci_no.Focus();
        }
    }
}
