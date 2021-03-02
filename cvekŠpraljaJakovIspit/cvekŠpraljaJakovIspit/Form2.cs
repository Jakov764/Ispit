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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        List<Osoba> List = new List<Osoba>();

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(txtIme.Text, txtPrez.Text, txtOib.Text, txtDate.Text);
            
            this.Close();
        }
    }
}
