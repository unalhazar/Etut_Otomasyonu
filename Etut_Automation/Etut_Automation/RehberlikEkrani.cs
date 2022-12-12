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
    public partial class RehberlikEkrani : Form
    {
        public RehberlikEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciPaneli fr = new OgrenciPaneli();
            fr.Show();
            
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void RehberlikEkrani_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //Ad Soyad            
            SqlCommand komut1 = new SqlCommand("Select RehberlikAdSoyad From Tbl_Rehberlik where RehberlikTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Ogretmenleri Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (OgretmenAd+ ' ' + OgretmenSoyad) as 'Ogretmenler',OgretmenBrans From Tbl_Ogretmenler", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşları combobox çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Etutler (EtutTarih,EtutSaat,EtutBrans,EtutOgretmen) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbOgretmen.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Etüt Oluşturuldu");

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOgretmen.Items.Clear();
            SqlCommand komut = new SqlCommand("Select OgretmenAd,OgretmenSoyad From Tbl_Ogretmenler Where OgretmenBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbOgretmen.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");

        }

        private void btnOgretmenPanel_Click(object sender, EventArgs e)
        {
            OgretmenPaneli drp = new OgretmenPaneli();            
            drp.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            BransPaneli frb = new BransPaneli();
            frb.Show();
        }

        private void btnEtutListe_Click(object sender, EventArgs e)
        {
            EtutListesi etl = new EtutListesi();
            etl.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RehberlikGiris fr = new RehberlikGiris();
            fr.Show();
            this.Hide();
        }
    }
}
