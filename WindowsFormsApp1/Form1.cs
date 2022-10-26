using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nev_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void azonosito_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kesz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nev.Text) || azonosito.Value == 0 || string.IsNullOrEmpty(nyelvbox.Text) || string.IsNullOrEmpty(varosok.Text))
            {
                MessageBox.Show("Hiba");          
            }
            
        }

        private void nyelvbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
