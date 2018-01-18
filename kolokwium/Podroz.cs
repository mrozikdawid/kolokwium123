using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Podroz : IComparable<Podroz>
    {
        private string miasto;
        private int ileDni;

        public Podroz(string miasto, int ileDni)
        {
            this.miasto = miasto;
            this.ileDni = ileDni;
        }

        public override string ToString()
        {
            return " Miasto  " + miasto + " liczba dni " + ileDni + " ";
        }

        public int CompareTo(Podroz other)
        {
            return this.miasto.CompareTo(other.miasto);
        }
    }
}
