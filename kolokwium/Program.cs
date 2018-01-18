using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            













            //-----------------------------------------------------------------------------------------------


            List<Podroz> list1 = new List<Podroz>();
            list1.Add(new Podroz("Warszawa",3));
            list1.Add(new Podroz("krakow", 4));
            list1.Add(new Podroz("Olsztyn", 2));
            list1.Add(new Podroz("Wroclaw", 1));
            list1.Add(new Podroz("Olsztynek", 2));

            list1.Sort();

            
            foreach (var x in list1)
            Console.Write("   {0}", x);

            



            Console.ReadKey();

        }
    }
}
