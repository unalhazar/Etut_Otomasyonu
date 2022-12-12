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
    public partial class EtutListesi : Form
    {
        public EtutListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl =  new sqlbaglantisi();
        private void EtutListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Etutler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
