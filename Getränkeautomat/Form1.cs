using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Getränkeautomat
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"250623__kwahmah-02__throwing-can.wav");
        System.Media.SoundPlayer playerwater = new System.Media.SoundPlayer(@"210437__soundscape-leuphana__20131202-bottle-falling-on-foor-zoomh4nxy.wav");
        MuenzeinwurfRestgeld geld = new MuenzeinwurfRestgeld();
        Random rnd = new Random();
        int cola = 999;
        int fanta = 999;
        int icetea = 999;
        int spezi = 999;
        int sprite = 999;
        int water = 999;
        Produkt produkt = new Produkt();
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_cola_Click(object sender, EventArgs e)
        {
            produkt.preis = 1.20;
            produkt.produkt = "Cola";
            lbl_Preis.Text = produkt.produkt + " = " + Convert.ToString(produkt.preis) + "€";
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

        private void pb_fanta_Click(object sender, EventArgs e)
        {
            produkt.preis = 1.50;
            produkt.produkt = "Fanta";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

        private void pb_icetea_Click(object sender, EventArgs e)
        {
            produkt.preis = 1.80;
            produkt.produkt = "IceTea";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

        private void pb_spezi_Click(object sender, EventArgs e)
        {
            produkt.preis = 1.10;
            produkt.produkt = "Spezi";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

        private void pb_sprite_Click(object sender, EventArgs e)
        {
            produkt.preis = 1.60;
            produkt.produkt = "Sprite";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis +"€";
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

        private void pb_water_Click(object sender, EventArgs e)
        {
            produkt.preis = 0.80;
            produkt.produkt = "Wasser";
            lbl_Preis.Text = produkt.produkt + " = " + produkt.preis + "€";
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

        private void lbl_Preis_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_5c_Click(object sender, EventArgs e)
        {
            geld.geldhinzufuegen(0.05);
            lbl_kontostand.Text = "Kontostand" + " = " + Convert.ToString(geld.getKontostand()) + "€";
        }

        private void btn_10c_Click(object sender, EventArgs e)
        {
            geld.geldhinzufuegen(0.10);
            lbl_kontostand.Text = "Kontostand" + " = " + Convert.ToString(geld.getKontostand()) + "€";
        }

        private void btn_20c_Click(object sender, EventArgs e)
        {
            geld.geldhinzufuegen(0.20);
            lbl_kontostand.Text = "Kontostand" + " = " + Convert.ToString(geld.getKontostand()) + "€";
        }

        private void btn_50c_Click(object sender, EventArgs e)
        {
            geld.geldhinzufuegen(0.50);
            lbl_kontostand.Text = "Kontostand" + " = " + Convert.ToString(geld.getKontostand()) + "€";
        }

        private void btn_100c_Click(object sender, EventArgs e)
        {
            geld.geldhinzufuegen(1.00);
            lbl_kontostand.Text = "Kontostand" + " = " + Convert.ToString(geld.getKontostand()) + "€";
        }

        private void btn_200c_Click(object sender, EventArgs e)
        {
            geld.geldhinzufuegen(2.00);
            lbl_kontostand.Text = "Kontostand" + " = " + Convert.ToString(geld.getKontostand()) + "€";
        }

        private void pb_cola_DoubleClick(object sender, EventArgs e)
        {
            produkt.preis = 1.20;
            if (geld.getKontostand() - Convert.ToDouble(produkt.preis) >= 0)
            {
                if (cola == 999)
                {
                    cola = rnd.Next(3, 8);
                }
                if (cola == 0)
                {
                    lbl_cola.BackColor = Color.Red;
                    pb_cola.Enabled = false;
                }
                else
                {
                    lbl_cola.BackColor = Color.Lime;
                    geld.geldhinzufuegen(Convert.ToDouble(produkt.preis) * -1);
                    lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
                    player.Play();
                    cola--;
                }
            }
            else
            {
                lbl_kontostand.Text = "Zu wenig";
            }
        }

        private void pb_fanta_DoubleClick(object sender, EventArgs e)
        {
            produkt.preis = 1.50;
            if (geld.getKontostand() - Convert.ToDouble(produkt.preis) >= 0)
            {
                if (fanta == 999)
                {
                    fanta = rnd.Next(3, 8);
                }
                if (fanta == 0)
                {
                    lbl_fanta.BackColor = Color.Red;
                    pb_fanta.Enabled = false;
                }
                else
                {
                    lbl_fanta.BackColor = Color.Lime;
                    geld.geldhinzufuegen(Convert.ToDouble(produkt.preis) * -1);
                    lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
                    player.Play();
                    fanta--;
                }
            }
            else
            {
                lbl_kontostand.Text = "Zu wenig";
            }
        }

        private void pb_icetea_DoubleClick(object sender, EventArgs e)
        {
            produkt.preis = 1.80;
            if (geld.getKontostand() - Convert.ToDouble(produkt.preis) >= 0)
            {
                if (icetea == 999)
                {
                    icetea = rnd.Next(3, 8);
                }
                if (icetea == 0)
                {
                    lbl_icetea.BackColor = Color.Red;
                    pb_icetea.Enabled = false;
                }
                else
                {
                    lbl_icetea.BackColor = Color.Lime;
                    geld.geldhinzufuegen(Convert.ToDouble(produkt.preis) * -1);
                    lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
                    player.Play();
                    icetea--;
                }
            }
            else
            {
                lbl_kontostand.Text = "Zu wenig";
            }
        }

        private void pb_spezi_DoubleClick(object sender, EventArgs e)
        {
            produkt.preis = 1.10;
            if (geld.getKontostand() - Convert.ToDouble(produkt.preis) >= 0)
            {
                if (spezi == 999)
                {
                    spezi = rnd.Next(3, 8);
                }
                if (spezi == 0)
                {
                    lbl_spezi.BackColor = Color.Red;
                    pb_spezi.Enabled = false;
                }
                else
                {
                    lbl_spezi.BackColor = Color.Lime;
                    geld.geldhinzufuegen(Convert.ToDouble(produkt.preis) * -1);
                    lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
                    player.Play();
                    spezi--;
                }
            }
            else
            {
                lbl_kontostand.Text = "Zu wenig";
            }
            
        }

        private void pb_sprite_DoubleClick(object sender, EventArgs e)
        {
            produkt.preis = 1.60;
            if (geld.getKontostand() - Convert.ToDouble(produkt.preis) >= 0)
            {
                if (sprite == 999)
                {
                    sprite = rnd.Next(3, 8);
                }
                if (sprite == 0)
                {
                    lbl_sprite.BackColor = Color.Red;
                    pb_sprite.Enabled = false;
                }
                else
                {
                    lbl_sprite.BackColor = Color.Lime;
                    geld.geldhinzufuegen(Convert.ToDouble(produkt.preis) * -1);
                    lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
                    player.Play();
                    sprite--;
                }
            }
            else
            {
                lbl_kontostand.Text = "Zu wenig";
            }
        }

        private void pb_water_DoubleClick(object sender, EventArgs e)
        {
            produkt.preis = 0.80;
            if (geld.getKontostand() - Convert.ToDouble(produkt.preis) >= 0)
            {
                if (water == 999)
                {
                    water = rnd.Next(3, 8);
                }
                if (water == 0)
                {
                    lbl_water.BackColor = Color.Red;
                    pb_water.Enabled = false;
                }
                else
                {
                    lbl_water.BackColor = Color.Lime;
                    geld.geldhinzufuegen(Convert.ToDouble(produkt.preis) * -1);
                    lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
                    playerwater.Play();
                    water--;
                }
            }
            else
            {
                lbl_kontostand.Text = "Zu wenig";
            }
        }

        private void lbl_cola_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fanta_Click(object sender, EventArgs e)
        {

        }

        private void lbl_icetea_Click(object sender, EventArgs e)
        {

        }

        private void lbl_spezi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sprite_Click(object sender, EventArgs e)
        {

        }

        private void lbl_water_Click(object sender, EventArgs e)
        {

        }

        private void lbl_kontostand_Click(object sender, EventArgs e)
        {

        }

        private void btn_restgeld_Click(object sender, EventArgs e)
        {
            geld.restgeldausgeben();
            lbl_kontostand.Text = "Kontostand = " + geld.getKontostand() + "€";
        }

    }
}
