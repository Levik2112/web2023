using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzemangyag
{
    internal class adatok
    {
        public DateTime datum;
        public int benzinAr;
        public int gazolajAr;
        double euro = 307.7;
        public adatok(string sor)
        {
            string[] vag = sor.Split(";");

            datum = DateTime.Parse(vag[0]);
            benzinAr = int.Parse(vag[1]);
            gazolajAr = int.Parse(vag[2]);
            

        }
        public int kulonbseg()
        {
            return Math.Abs(benzinAr - gazolajAr);
        }
        public double benzinEuro()
        {
            return benzinAr / euro;
        }
        public double gazEuro()
        {
            return gazolajAr / euro;
        }
        public string filebaIr()
        {
            return datum.ToString() + ";" + Math.Round(benzinEuro(),2) + ";" + Math.Round(gazEuro(), 2);
        }
    }
}
