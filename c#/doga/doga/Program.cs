StreamReader olvas = new StreamReader("adathalmaz.csv");
olvas.ReadLine();

List<int> perc = new List<int>();
List<int> homero1 = new List<int>();
List<int> homero2 = new List<int>();
List<int> homero3 = new List<int>();
List<int> homero4 = new List<int>();
List<int> darab = new List<int>();


while (!olvas.EndOfStream)
{
    string[] vag = olvas.ReadLine().Split(";");
    perc.Add(int.Parse(vag[1]));
    homero1.Add(int.Parse(vag[2]));
    homero2.Add(int.Parse(vag[3]));
    homero3.Add(int.Parse(vag[4]));
    homero4.Add(int.Parse(vag[5]));
    darab.Add(int.Parse(vag[5]));

}

