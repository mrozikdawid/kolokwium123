using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Express : Pociąg
    {

        public override void ObliczCene()
        {
            cenaBiletu = 200;
        }

        public override string ToString()
        {
            return "Express:" + " Ilosc Miejsc: " + iloscMiejsc + "dlugosc trasy" +  " Cena biletu: " + cenaBiletu;
        }

    }
}
