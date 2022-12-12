using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Etut_Automation
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LES95V2\\MSSQLSERVER01;Initial Catalog=Etut_Automation;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
