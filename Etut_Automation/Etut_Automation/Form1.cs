using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etut_Automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOgrenciGirisi_Click(object sender, EventArgs e)
        {
            OgrenciGiris fr = new OgrenciGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnOgretmenGirisi_Click(object sender, EventArgs e)
        {
            OgretmenGiris fr = new OgretmenGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnRehberlikGirisi_Click(object sender, EventArgs e)
        {
            RehberlikGiris fr = new RehberlikGiris();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Substring(1) + label4.Text.Substring(0, 1);
        }
    }
}
