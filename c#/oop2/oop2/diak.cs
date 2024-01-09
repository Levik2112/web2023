using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class diak:udvariasEmber
    {
        private int kor;
        public diak(string vNev,string kNev, int kor) : base(vNev, kNev)
        {
            this.kor = kor;
        }

        public void iskola()
        {
            if (kor < 2)
            {
                Console.WriteLine("oooaaaee");
            }
            else if (kor < 3) { Console.WriteLine("Bölcsibe"); }
            else if (kor < 3) { Console.WriteLine("Bölcsibe"); }
            else if (kor < 7) { Console.WriteLine("óvoda"); }
            else if (kor < 11) { Console.WriteLine("alsós"); }
            else if (kor < 15) { Console.WriteLine("felsős"); }
            else if (kor < 20) { Console.WriteLine("techinkum"); }
            else if (kor < 25) { Console.WriteLine("egyetem"); }
            else { Console.WriteLine("FElmöttm"); }
        }
        public void koszon(diak diakValtozo)
        {
            Console.WriteLine("Csá {0}!",diakValtozo.keresztNev);
        }
    }
}
