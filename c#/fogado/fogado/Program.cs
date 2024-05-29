using fogado;
List<adatok> foglalasok = new List<adatok>();

StreamReader olvas = new StreamReader("fogado.txt");
while (!olvas.EndOfStream)
{
    string sor  = olvas.ReadLine();
    foglalasok.Add(new adatok(sor));
}
olvas.Close();

Console.WriteLine("2.Feladat");
Console.WriteLine("Foglalások száma: {0}",foglalasok.Count());

Console.WriteLine("3.Feladat");
Console.Write("Adjon meg egy nevet: ");
string tanarNev = Console.ReadLine();
int db = 0;
//Console.WriteLine(tanarNev);

for (int i = 0; i < foglalasok.Count(); i++)
{
    if (tanarNev == foglalasok[i].nev)
    {
        db++;
        
    }
    
}
if (db > 0)
{
    Console.WriteLine("{0} néven {1} időpontfoglalás van.", tanarNev, db);
}
else
{
    Console.WriteLine("A megadott néven nincs időpontfoglalás");
}

Console.WriteLine("4.Feladat");
Console.Write("Adjon meg egy érvényes időpontot (pl. 17:10): ");
string idopont= Console.ReadLine(); 
List<string> nevek = new List<string>();
for (int i = 0; i < foglalasok.Count; i++)
{
    if (idopont == foglalasok[i].idopont)
    {
        nevek.Add(foglalasok[i].nev);
    }
}
nevek.Sort();
for (int i = 0; i < nevek.Count; i++)
{
    Console.WriteLine(nevek[i]);
}
File.WriteAllLines(idopont.Replace(":", "") + ".txt",nevek);

adatok min = foglalasok[0];
//Console.WriteLine(min);

for (int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].foglalas<min.foglalas)
    {
        min = foglalasok[i];
    }
}

Console.WriteLine(min);