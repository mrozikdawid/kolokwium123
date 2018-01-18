using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            ObliczCene();
        }

        public override string ToString()
        {
            return " Ilosc Miejsc: " + iloscMiejsc + " Cena biletu: " + cenaBiletu;
        }


    }
}
