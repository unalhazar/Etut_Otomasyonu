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
    public partial class OgrenciPaneli : Form
    {
        public OgrenciPaneli()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenciler (OgrenciAd,OgrenciSoyad,OgrenciNo,OgrenciTelefon,OgrenciSifre,OgrenciCinsiyet) values (@d1,@d2,@d3,@d4,@d5,@d6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", txtOgrencino.Text);
            komut.Parameters.AddWithValue("@d4", mskTel.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.Parameters.AddWithValue("@d6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi");

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgrenciPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Ogrenciler", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Ogrenciler where OgrenciNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOgrencino.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Ogrenciler set OgrenciAd=@d1,OgrenciSoyad=@d2,OgrenciTelefon=@d4,OgrenciSifre=@d5,OgrenciCinsiyet=@d6 where OgrenciNo=@d3",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", txtOgrencino.Text);
            komut.Parameters.AddWithValue("@d4", mskTel.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.Parameters.AddWithValue("@d6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtOgrencino.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RehberlikEkrani fr = new RehberlikEkrani();
            fr.Show();
            this.Hide();
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Ogrenciler", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
    }
}
