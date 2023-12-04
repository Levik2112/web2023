//1.feladat
StreamReader olvas = new StreamReader("adathalmaz.csv");
olvas.ReadLine();
List<int> perc = new List<int>();
List<double> homero1 = new List<double>();
List<double> homero2 = new List<double>();
List<double> homero3 = new List<double>();
List<double> homero4 = new List<double>();
List<int> darab = new List<int>();

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    string[] vag = sor.Split(";");
    perc.Add(Convert.ToInt32(vag[0]));
    homero1.Add(Convert.ToDouble(vag[1]));  
    homero2.Add(Convert.ToDouble(vag[2]));
    homero3.Add(Convert.ToDouble(vag[3]));
    homero4.Add(Convert.ToDouble(vag[4]));
    darab.Add(Convert.ToInt32(vag[5]));
}
olvas.Close();
//2.feladat
Console.WriteLine("2.feladat: Az adatok között {0} idöpont szerepel.", perc.Count());

Console.WriteLine();

//3.feladat

//Console.WriteLine(darab.Last());
//Console.WriteLine(perc.Last()/60);
int atlagTerm = darab.Last() / (perc.Last()/60);
Console.WriteLine("3.feladat: A gyártósor átlagos termelése:{0}",atlagTerm);
//4.feladat
Console.WriteLine();

Console.WriteLine("4.feladat: Az első fázis legkisebb hőmérséklete: {0} °C", homero1.Min());

Console.WriteLine();

Console.WriteLine("A második fázis legkisebb hőmérséklete: {0} °C", homero2.Min());

Console.WriteLine();

Console.WriteLine("A harmadik fázis legkisebb hőmérséklete: {0} °C", homero3.Min());

Console.WriteLine();

Console.WriteLine("A negyedik fázis legkisebb hőmérséklete: {0} °C", homero4.Min());

Console.WriteLine();

//5.feladat
/*
double hoMax = homero1.Max();
Console.WriteLine(hoMax);
int percMikor = 0;
for (int i = 0; i < homero1.Count; i++)
{
    //Console.WriteLine(homero1[i]);
    if (homero1[i]==hoMax)
    {
        percMikor += 5;
        Console.WriteLine(percMikor);
    }
}
*/
Console.WriteLine("5.feladat: Az első fázis legmagasabb hőmérséklete: {0} °C volt,ekkor {1} perc.", homero1.Max(), perc[44]);