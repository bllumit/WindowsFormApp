using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btnTopla_Click(object sender, EventArgs e)
        {
            lblSonuc.Text=(Convert.ToInt32(txtDeger1.Text) + Convert.ToInt32(txtDeger2.Text)).ToString();
         
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (Convert.ToInt32(txtDeger1.Text) - Convert.ToInt32(txtDeger2.Text)).ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (Convert.ToDouble(txtDeger1.Text) / Convert.ToDouble(txtDeger2.Text)).ToString();
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (Convert.ToInt32(txtDeger1.Text) * Convert.ToInt32(txtDeger2.Text)).ToString();
        }
    }
}
