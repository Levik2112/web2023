using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Kérek egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine("A bekért szöveg: "+ szoveg);

            //üres sorig

            while (szoveg !="")
            {
                Console.Write("Kérek egy szót: ");
                szoveg = Console.ReadLine();
            }

                //HF:szavak bekér,üres végejelig,valahogy elválasztva

                Console.Write("Kérek egy nem egész számot: ");
                double szam = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A szám négyzete: "+ (szam*szam)+1);
                */

            //egész szám utánna annyi szó amekkora a szám
            /*
            Console.Write("Egy egész számot kérek: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(szam2);
            int i = 1;
            while (i <= szam2)
            {
                Console.Write("Kérem az "+ i + "."+ " szót: ");
                string szoveg = Console.ReadLine();
                i += 1;
            }
            for (int k = 1; k <= szam2; k++)
            {
                Console.Write("Kérem az " + k + "." + " szót: ");
                string szoveg = Console.ReadLine();
            }
            */

            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy szó hosszúságot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            for (int k = 1; k <= szam; k++)
            {
                Console.Write("Kérem az " + k + "." + " szót: ");
                string szoveg = Console.ReadLine();

                if (szoveg.Length<szam2)
                {
                    
                    Console.Write("Túl rövid! \n");
                }
                else if(szoveg.Length>szam2)
                {
                    
                    Console.Write("Túl hosszú! \n");
                }
                

            }
            //hf 2 számot bekérni 2 közti számok négyzetét kiiratni

        }
    }
}
