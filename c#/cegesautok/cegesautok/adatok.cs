using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cegesautok
{
    internal class adatok
    {
        public int nap;
        public string ido;
        public string rendszam;
        public int szemelyId;
        public int km;
        public bool parkol;

        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");

            nap = Convert.ToInt32(vag[0]);
            ido = vag[1];
            rendszam = vag[2];
            szemelyId = Convert.ToInt32(vag[3]);
            km = Convert.ToInt32(vag[4]);
            parkol = vag[5] == "1";
        }

        public bool parkolE()
        {
            return parkol;
        }
        public string f3sor()
        {
            return ido + " " + rendszam + " " + szemelyId + " "+(parkol ? "be" : "ki");
        }
    }
}
