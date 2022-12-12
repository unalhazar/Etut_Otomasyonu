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
    public partial class OgrenciBilgiDuzenle : Form
    {
        public OgrenciBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string ogno;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgrenciBilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtno.Text = ogno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenciler where OgrenciNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text= dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Ogrenciler set OgrenciAd=@p1,OgrenciSoyad=@p2,OgrenciTelefon=@p3,OgrenciSifre=@p4 where OgrenciNo=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktel.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", txtno.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkrani fr = new OgrenciEkrani();            
            fr.Show();
            this.Hide();
        }
    }
}
