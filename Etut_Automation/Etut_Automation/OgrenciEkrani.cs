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
    public partial class OgrenciEkrani : Form
    {
        public OgrenciEkrani()
        {
            InitializeComponent();
        }
        public string no;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void OgrenciEkrani_Load(object sender, EventArgs e)
        {
            Lbl_OgrenciNo.Text = no;
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad From Tbl_Ogrenciler where OgrenciNo=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Lbl_OgrenciNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_Ogrenci_AdSoyad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Etutler where OgrenciNo=" + no, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
                

               
        }

        private void Cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Ogretmen.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select OgretmenAd,OgretmenSoyad From Tbl_Ogretmenler where OgretmenBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", Cmb_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                Cmb_Ogretmen.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void Cmb_Ogretmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Etutler where EtutBrans='" + Cmb_Brans.Text + "'" + " and EtutOgretmen='" + Cmb_Ogretmen.Text + "' and EtutDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void LnkBilgi_Duzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrenciBilgiDuzenle fr = new OgrenciBilgiDuzenle();
            fr.ogno = Lbl_OgrenciNo.Text;
            fr.Show();
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txttarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
        
        private void BtnEtut_Al_Click(object sender, EventArgs e)

        {                   
                     
            
            
                SqlCommand komut = new SqlCommand("Update Tbl_Etutler Set EtutDurum=1, OgrenciNo=@p1,Etuticerik=@p2 where Etutid=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Lbl_OgrenciNo.Text);
                komut.Parameters.AddWithValue("@p2", richbox_Etuticerik.Text);
                komut.Parameters.AddWithValue("@p3", txtid.Text);
                komut.ExecuteNonQuery();              
                bgl.baglanti().Close();
                MessageBox.Show("Etüt Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciGiris fr = new OgrenciGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Etutler where OgrenciNo=" + no, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
