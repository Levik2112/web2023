using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            //alap műveletek,típusok
            Console.WriteLine("haló");
            int szam = 6;
            Console.WriteLine(szam);
            int szam2 = -2;
            Console.WriteLine(szam2);
            double szam3 = 3.25;
            Console.WriteLine(szam3);
            char kar = 'a';

            //operátorok 
            Console.WriteLine(kar);
            //char visszalakítása számból karakterré kasztrálással
            Console.WriteLine((char)(kar + 2));
            Console.WriteLine(10 / 3);
            Console.WriteLine(10 % 3);
            //if,else if switch,case működése
            int a;
            a = 5;
            if (a > 2)
            {
                Console.WriteLine("Nagyobb");
            }
            else if (a < 2)
            {
                Console.WriteLine("Kisebb");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("páros");
            }
            else
            {
                Console.WriteLine("Egyenlő!");
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("kettő");
                    break;
                case 3:
                    Console.WriteLine("három");
                    break;
                case 4:
                    Console.WriteLine("négy");
                    break;
                default:
                    Console.WriteLine("valami más");
                    break;
            }
            //while ciklus
            double i = 1;
            while (i < 3)
            {

                Console.WriteLine(i);
                i += .1;
            }

            do
            {
                i -= .2;
                Console.WriteLine(i);
            }
            while (i > 2);

            //a-tól z-ig kiiratás
            char abc = 'a';
            while (abc <= 'z')
            {
                
                Console.Write(abc);
                abc = (char)(abc + 1);
               
            }
            Console.WriteLine();

            int uj = 32;
            while (uj <= 255)
            {
                Console.Write((char)uj + " ");
                uj += 1;
                if (uj % 8 == 0)
                {
                    Console.WriteLine();
                }
            }
            int szamol = 0;
            for (int b = 100; b <=1000; b++)
            {

                szamol += b;
                

            }
            Console.WriteLine(szamol);
            //vissza felé számloás 1
            for (int k = 9; k >=0; k--)
            {
                Console.WriteLine(k);
            }
            //vissza felé számloás 2
            for (int c = 0; c < 10;c++)
            {
                Console.WriteLine(9-c);
            }

        }
            

            

            

          
    }
}
