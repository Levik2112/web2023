using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class udvariasEmber:ember
    {
        public udvariasEmber(string vNev,string kNev):base(vNev, kNev)
        {

        }
        public void koszon()
        {
            Console.WriteLine("Szia uram");
        }
        public void koszon(ember emberValtozoNev)
        {
            Console.WriteLine("Szia {0} uram!",emberValtozoNev.teljesNev);
        }
        public void koszonNevvel()
        {
            Console.WriteLine("Szia uram! {0} vagyok.", teljesNev);
        }
        public void koszonNevvel(ember emberValtozoNev)
        {
            Console.WriteLine("Szia {1} uram! {0} vagyok.",teljesNev,emberValtozoNev.vezetekNev);
        }
    }
}
