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
    public partial class OgretmenBilgiDuzenle : Form
    {
        public OgretmenBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCno;
        private void OgretmenBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogretmenler where  OgretmenTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                mskTel.Text = dr[6].ToString();
                TxtSifre.Text = dr[5].ToString();

            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Ogretmenler set OgretmenAd=@p1,OgretmenSoyad=@p2,OgretmenBrans=@p3,OgretmenSifre=@p4,OgretmenTel=@p5 where OgretmenTC=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTel.Text);
            komut.Parameters.AddWithValue("@p6", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkrani fr = new OgrenciEkrani();
            fr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
