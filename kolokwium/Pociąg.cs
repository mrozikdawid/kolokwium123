using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Pociąg : SrodekLokomocji
    {
        private int dlugoscTrasy;

        

        public override void ObliczCene()
        {
            if(dlugoscTrasy > 100)
            {
                cenaBiletu = dlugoscTrasy * 1.43 ;
            }
            else
            {
                cenaBiletu=50;
            }
        }
        public Pociąg()
        {

        }

        public Pociąg(int iloscMiejsc , int dlugoscTrasy)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.dlugoscTrasy = dlugoscTrasy;
            ObliczCene();
        }

        public override string ToString()
        {
            return  " Ilosc Miejsc: " + iloscMiejsc + "długosc trasy  " + dlugoscTrasy + " Cena biletu: " + cenaBiletu; 
        }

    }
}
