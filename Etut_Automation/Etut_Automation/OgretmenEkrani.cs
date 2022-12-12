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
    public partial class OgretmenEkrani : Form
    {
        public OgretmenEkrani()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;
        private void OgretmenEkrani_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            //Ogretmen ad soyad
            SqlCommand komut = new SqlCommand("Select OgretmenAd, OgretmenSoyad From Tbl_Ogretmenler where OgretmenTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Etutler
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Etutler where EtutOgretmen='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            OgretmenBilgiDuzenle fr = new OgretmenBilgiDuzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Rchİcerik.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtetutid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            msketuttarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtOgrencino.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            checkonay.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgretmenGiris fr = new OgretmenGiris();
            fr.Show();
            this.Hide();
        }

        private void btnEtutonay_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Etutler set EtutOgretmenOnay=@p1 where Etutid=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", checkonay.Text="true");
            komut.Parameters.AddWithValue("@p2", txtetutid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Etüt Onaylandı.");
        }

        private void btnEtutRed_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Etutler set EtutOgretmenRed=@p1 where Etutid=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", chechRed.Text = "true");
            komut.Parameters.AddWithValue("@p2", txtetutid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Etüt Red Verildi.");
        }

        private void checkonay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Etutler where EtutOgretmen='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
