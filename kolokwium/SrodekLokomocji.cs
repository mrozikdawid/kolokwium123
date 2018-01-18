using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji()
        {

        }

        public virtual void ObliczCene()
        {
            cenaBiletu = 50;
        }

        public double CenaBiletu()
        {
            return cenaBiletu;
        }

    }
}
