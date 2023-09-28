using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orau
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Console.Write("Kérek egy számot: ");
           int szam = Convert.ToInt32(Console.ReadLine());

           //Console.Write(szam);
           for (int i = 0; i <=szam; i++)
           {
               Console.WriteLine(i*10);
           }
           */
            /*
            for (int i = 1; i <= szam; i++)
            {
                for (int k = 1; k <= szam; k++)
                {
                    Console.Write(i*k+"\t");
                }
                Console.WriteLine();


            }
            */
            //Console.WriteLine(szam);
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            while (szam.ToString().Length != 2)
            {
                Console.Write("Kérek egy számot: ");
                
                
            }
        }

    }
}
