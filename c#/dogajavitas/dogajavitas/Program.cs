//listak a kulonbozo adatok tarolasara
List<int> percek = new List<int>();
List<double> ho1  = new List<double>();
List<double> ho2 = new List<double>();
List<double> ho3 = new List<double>();
List<double> ho4 = new List<double>();
List<int> darab = new List<int>();

//betoltes 1. valtozata fugvennyel
void betolt()
{
    
    StreamReader olvas = new StreamReader("adathalmaz.csv");
    //elso sort beolvassa majd elfelejti
    olvas.ReadLine();
    while (!olvas.EndOfStream)
    {
        //beolvassuk egy valtozoba és el spliteljuk egy tombbe
        string sor = olvas.ReadLine();
        string[] vag = sor.Split(";");
        //feltoltjuk a listakat a megfelelo elemekkel vag[0] = perc,vag[1] = homerseklet 1....
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
    //Console.WriteLine(darab[1]);
    olvas.Close();
}
//betoltes 2. valtozata fugvennyel
void betolt2()
{
    //az osszes sort beolvassuk egy tombbe
    string[] sorok = File.ReadAllLines("adathalmaz.csv");
    // i=0 mert ez kihagyja az elso sort
    for (int i = 1; i < sorok.Length; i++)
    {
        // itt sorok[i]-edik eleme kell
        string[] vag = sorok[i].Split(";");
        //feltoltjuk a listakat a megfelelo elemekkel vag[0] = perc,vag[1] = homerseklet 1....
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}

//betoltes 3. valotozata fugvennyel
void betolt3()
{
    //az osszes sort beolvassuk egy tombbe
    string[] sorok = File.ReadAllLines("adathalmaz.csv").ToList().Skip(1).ToArray();
    //string sor jon vissza a sorokbol
    foreach (string sor in sorok) //skip kihagyja az elso elemet
    {
        // sor-t kell splitelni mert az a ciklusban
        string[] vag = sor.Split(";");
        //feltoltjuk a listakat a megfelelo elemekkel vag[0] = perc,vag[1] = homerseklet 1....
        percek.Add(int.Parse(vag[0]));
        ho1.Add(double.Parse(vag[1]));
        ho2.Add(double.Parse(vag[2]));
        ho3.Add(double.Parse(vag[3]));
        ho4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}

betolt();

void feladat2()
{
    Console.WriteLine("2.feladat\nEnnyi adatsor van {0}", percek.Count);
}
//2.feladat
feladat2();
Console.WriteLine("3.feladat\nÁtlagos termelés {0} db/óra", darab[darab.Count-1]/24);
Console.WriteLine("4.feladat\n Min1: {0} \n Min2: {1} \n Min3: {2} \n Min4: {3}",ho1.Min(),ho2.Min(),ho3.Min(),ho4.Min());

//minimum kereses maskepp
double minimum = ho1[0];
for (int i = 0; i < ho1.Count; i++)
{
    if (ho1[i]<minimum)
    {
        minimum = ho1[i];
    }
}

//maximuim kereses
double maximum = ho1[0];
int maxIndex = 0;
for (int i = 0; i < ho1.Count; i++)
{
    if (ho1[i]>maximum)
    {
        maximum = ho1[i];
        maxIndex = i;
    }
}
Console.WriteLine("5.feladat\n{0} fok, {1} perc", maximum, percek[maxIndex]);
List<int> darab5perc = new List<int>();
darab5perc.Add(darab[0]);
for (int i = 1; i < darab.Count; i++)
{
    darab5perc.Add(darab[i]- darab[i-1]);
}