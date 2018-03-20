using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Getränkeautomat
{
    class MuenzeinwurfRestgeld
    {
        private double kontostand = 0;
        private double restgeld = 0;

        public double getKontostand()
        {
            return kontostand;
        }

        public double getRestgeld()
        {
            return restgeld;
        }

        public void restgeldausgeben()
        {
            kontostand = 0;
            restgeld = 0;
        }

        public void geldhinzufuegen(double muenze)
        {
            kontostand += muenze;
        }

        public void restgeldberechnen(string preisGetraenkST)
        {
            double preisGetraenkDO = Convert.ToDouble(preisGetraenkST);
            restgeld = kontostand - preisGetraenkDO;
            kontostand = restgeld;
            restgeld = 0;
        }
    }
}