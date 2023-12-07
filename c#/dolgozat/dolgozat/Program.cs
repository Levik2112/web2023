//Készítsetek egy listát, ami 500 darab, 5 jegyű számot tartalmaz! A számok legyenek véletlenszerűek! Írjátok ki a "szamok.csv" file-ba! 5 pont

using System.Collections.Generic;

List<int> szamLista = new List<int>();
Random rand = new Random();
for (int i = 0; i < 500; i++)
{
    szamLista.Add(rand.Next(10000,100000));
}
/*
for (int i = 0; i < szamLista.Count; i++)
{
    Console.WriteLine(szamLista[i]);
}
*/
StreamWriter ir = new StreamWriter("szamok.csv");
for (int i = 0;i < szamLista.Count; i++)
{
    ir.WriteLine(szamLista[i]);
}
ir.Close();

//Készítsetek egy függvényt, ami visszaadja hogy mennyi páros van a listában(a lista paraméterként átadva) 5 pont
List<int> paros = new List<int>();

void parosSzamok()
{
    for (int i = 0; i < szamLista.Count; i++)
    {
        if (szamLista[i] % 2 == 0)
        {
           paros.Add(szamLista[i]);

        }
    }

}
parosSzamok();
Console.WriteLine("A listában {0} db páros szám van", paros.Count);
Console.WriteLine();

//Számoljátok ki és írjátok ki (SZÉPEN, EGÉSZ MONDATBAN!) a páratlan számok összegét! Függvénnyel. 4 pont
List<int> paratlan = new List<int>();
void paratlanSzamok()
{
    for (int i = 0; i < szamLista.Count; i++)
    {
        if (szamLista[i]%2 !=0)
        {
            paratlan.Add(szamLista[i]);
        }
    }

}
paratlanSzamok();
Console.WriteLine("{0} db páratlan szám van,és az összegük {1}",paratlan.Count,paratlan.Sum());
Console.WriteLine();

//Melyik nagyobb, a lista első felének összege, vagy a másodiké? 4 pont
int listaKozepe = szamLista.Count / 2;
List<int> elsoFel = new List<int>();
List<int> masodikFel = new List<int>();

//Console.WriteLine(elsoFel.Count);

for (int i = 0; i < szamLista.Count/2; i++)
{
   
    elsoFel.Add(szamLista[i]);
    
}
//Console.WriteLine(elsoFel.Count);
for (int i = listaKozepe; i < szamLista.Count; i++)
{
    masodikFel.Add(szamLista[i]);
}
//Console.WriteLine(masodikFel.Count);

Console.WriteLine("A lista első felének összege {0}, a második felének összege {1}",elsoFel.Sum(),masodikFel.Sum());
if (elsoFel.Sum()>masodikFel.Sum())
{
    Console.WriteLine("Az első fele nagyobb!");
}

else
{
    Console.WriteLine("A második fele nagyobb!");
}

//Mennyi 3xxxx szerű szám van? 4 pont
/*
for (int i = 0; i < szamLista.Count; i++)
{
    if (szamLista[0]==3)
    {
        Console.WriteLine("asd");
    }
}
*/


//Válogassátok szét az első számjegy szerint, és írjátok ki  külön file-okba, a konzolba hogy melyikből mennyi van! 8 pont

int[] darabok = new int[10];
for (int i = 0; i < szamLista.Count; i++)
{
    darabok[szamLista[i] / 10000]++;
    ir = new StreamWriter(szamLista[i] / 10000 + ".csv", true);
    ir.WriteLine(szamLista[i]);
    ir.Close();
}
for (int i = 1; i < darabok.Length; i++)
{
    Console.WriteLine("{0}: {1} db", i, darabok[i]);
}

//megoldas 2

List<string>[] szamok = new List<string>[10];
for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = new List<string>();
}
for (int i = 0; i < szamLista.Count; i++)
{
    szamok[szamLista[i] / 10000].Add(szamLista[i].ToString());
}