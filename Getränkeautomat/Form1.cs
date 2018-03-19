using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Getränkeautomat
{
    public partial class Form1 : Form
    {
        double preis;
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_cola_Click(object sender, EventArgs e)
        {
            preis = 1.20;
        }

        private void pb_fanta_Click(object sender, EventArgs e)
        {
            preis = 1.50;
        }

        private void pb_icetea_Click(object sender, EventArgs e)
        {
            preis = 1.80;
        }

        private void pb_spezi_Click(object sender, EventArgs e)
        {
            preis = 1.00;
        }

        private void pb_sprite_Click(object sender, EventArgs e)
        {
            preis = 1.60;
        }

        private void pb_water_Click(object sender, EventArgs e)
        {
            preis = 0.80;
        }


    }
}
