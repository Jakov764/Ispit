using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvekŠpraljaJakovIspit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        

        private void RichTxt_TextChanged(object sender, EventArgs e)
        {
            richTxt.Text = "2";
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            richTxt.Clear();
        }
    }
}
