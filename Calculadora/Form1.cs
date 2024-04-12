using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "9";
        }
    }
}
