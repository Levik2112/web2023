using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlasd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam < 0)
            {
                Console.WriteLine("A szám nem lehet kisebb 0-nál");
            }
            else if (szam > 999999)
            {
                Console.WriteLine("A szám nem lehet nagyobb 999999-nál");
            }
            else
            {
                Console.WriteLine("A te számod: " + szam + " ,a hossza " + szam.ToString().Length);
            }

            int szam2 = 1;
            while (szam2>0 && szam2<=999999)
            {
                Console.Write("Kérek egy számot: ");
                szam2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A te számod: " + szam2 + " ,a hossza " + szam2.ToString().Length);
            }
        }
    }
}

//addgi kell osztani 10-el amig az osztas eredmenye mnagyobb mint 0 ciklussal
