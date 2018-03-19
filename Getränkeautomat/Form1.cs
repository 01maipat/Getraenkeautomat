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
        Produkt produkt = new Produkt();
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_cola_Click(object sender, EventArgs e)
        {
            produkt.preis = "1.20";
            produkt.produkt = "Cola";
            lbl_Preis.Text = produkt.produkt + " = " + Convert.ToString(produkt.preis) + "€";
        }

        private void pb_fanta_Click(object sender, EventArgs e)
        {
            produkt.preis = "1.50";
            produkt.produkt = "Fanta";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
        }

        private void pb_icetea_Click(object sender, EventArgs e)
        {
            produkt.preis = "1.80";
            produkt.produkt = "IceTea";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
        }

        private void pb_spezi_Click(object sender, EventArgs e)
        {
            produkt.preis = "1.00";
            produkt.produkt = "Spezi";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
        }

        private void pb_sprite_Click(object sender, EventArgs e)
        {
            produkt.preis = "1.60";
            produkt.produkt = "Sprite";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis +"€";
        }

        private void pb_water_Click(object sender, EventArgs e)
        {
            produkt.preis = "0.80";
            produkt.produkt = "Wasser";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
        }

        private void lbl_Preis_Click(object sender, EventArgs e)
        {
            
        }



    }
}
