using uzemangyag;

List<adatok> valtozasok = new List<adatok>();
StreamReader olvas = new StreamReader("uzemanyag.txt");
while (!olvas.EndOfStream)
{
    valtozasok.Add(new adatok(olvas.ReadLine()));    
}
olvas.Close();
//3 feladat
Console.WriteLine("3.Feladat: Változások száma: {0}",valtozasok.Count);


//4 feladat
adatok minimum = valtozasok[0];
for (int i = 0; i < valtozasok.Count; i++)
{
	if (valtozasok[i].kulonbseg()<minimum.kulonbseg())
	{
		minimum = valtozasok[i];
	}
}
Console.WriteLine("4.Feladat: A legkisebb különbség: {0}",minimum.kulonbseg());

//5 feladat
int minHany = 0;
for (int i = 0; i < valtozasok.Count; i++)
{
	if (minimum.kulonbseg() == valtozasok[i].kulonbseg())
	{
		minHany++;
	}
}
Console.WriteLine("5.Feladat: A legkisebb különbség előfordulása: {0}", minHany);

bool volt = false;
for (int i = 0;i < valtozasok.Count; i++)
{
	if (DateTime.IsLeapYear(valtozasok[i].datum.Year))
	{
		if (valtozasok[i].datum.Month == 2 && valtozasok[i].datum.Day==24)
		{
            volt=true;
			break;
        }
	}
}
if (volt)
{
    Console.WriteLine("6.Feladat: Volt változás szökőnapon!");
}
else
{
    Console.WriteLine("6.Feladat: Nem volt változás szökőnapon!");
}
StreamWriter ir = new StreamWriter("euro.txt");
for (int i = 0; i < valtozasok.Count; i++)
{
	ir.WriteLine(valtozasok[i].filebaIr());
}

