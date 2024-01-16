using cegesautok;
List<adatok> autok = new List<adatok>();
StreamReader olvas = new StreamReader("autok.txt");
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    adatok ujAdat = new adatok(sor);
    autok.Add(ujAdat);
}
olvas.Close();
Console.WriteLine("2. Feladat");
for (int i = autok.Count-1; i >=0; i--)
{
    if (!autok[i].parkolE())
    {
        Console.WriteLine("{0}. nap rendszám: {1}", autok[i].nap, autok[i].rendszam);
        break;
    }
}

Console.WriteLine("3. Feladat");
Console.Write("Nap: ");
int nap=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Forgalom a(z) {0}. napon",nap);
for (int i = 0; i < autok.Count; i++)
{
    if (autok[i].nap == nap)
    {
        Console.Write("{0} {1} {2} ", autok[i].ido, autok[i].rendszam, autok[i].szemelyId);
        if (autok[i].parkolE() )
        {
            Console.WriteLine("be");
        }
        else
        {
            Console.WriteLine("ki");
        }
        
    }
}
for (int i = 0; i < autok.Count; i++)
{
    if (autok[i].nap == nap)
    {
        Console.WriteLine(autok[i].f3sor());
    }
    
}

int mennyiVanKint = 0;
for (int i = 0;i < autok.Count; i++)
{
    if (autok[i].parkolE())
    {
        mennyiVanKint--;
    }
    else
    {
        mennyiVanKint++;
    }
}
Console.WriteLine("4. Feladat");
Console.WriteLine("A hónap végén {0} autót nem hoztak vissza.",mennyiVanKint);

Dictionary<string,int> kivittek = new Dictionary<string,int>();
Dictionary<string,int> visszaHoztak = new Dictionary<string,int>();
for (int i = 0; i < autok.Count; i++)
{
    if (!kivittek.ContainsKey(autok[i].rendszam))
    {
        kivittek.Add(autok[i].rendszam, autok[i].km);
    }
    if (!visszaHoztak.ContainsKey(autok[i].rendszam))
    {
        visszaHoztak.Add(autok[i].rendszam, autok[i].km);
    }
    else
    {
        visszaHoztak[autok[i].rendszam] = autok[i].km;  
    }
}

Console.WriteLine("5. Feladat");
foreach (string key in kivittek.Keys)
{
    Console.WriteLine("{0} {1} km", key, visszaHoztak[key] - kivittek[key]);
}