/*
Console.Write("Hány db szót szeretnél?: ");
int szoSzam = Convert.ToInt32(Console.ReadLine());
string[] szoveg = new string[szoSzam];
for (int i = 0; i < szoveg.Length; i++)
{
    Console.Write("Kérek egy szót: ");
    szoveg[i]=Console.ReadLine();
}

string max = "";
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i].Length > max.Length)
    {
        max = szoveg[i];
    }
}
Console.WriteLine("A leghosszabb szó: {0}",max);

//index keresés
int maxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i]==max)
    {
        maxIndex = i;
    }
}

//max keresés 3
maxIndex = 0;
for(int i = 0;i < szoveg.Length; i++)
{
    if (szoveg[i].Length > szoveg[maxIndex].Length) 
    {
    maxIndex = i;
    }
}


string[] szavak = new string[] { "alma","körte",
                                "narancs","mandula",
                                "ananász","banán"} ;

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];

int rovidIndex=0;
int hosszuIndex=0;

for (int i = 0;i < szavak.Length;i++)
{
    if (szavak[i].Length<=5)
    {
        rovid[rovidIndex] = szavak[i];
        rovidIndex++;
    }
    else
    {
        hosszu[hosszuIndex++] = szavak[i];
        
    }
}

foreach(string i in rovid)
{
    Console.WriteLine(i);
}
foreach (string i in hosszu)
{
    Console.WriteLine(i);
}
*/

//hf: oldjuk meg h ne legyyen közte hézag


int[] szamok = new int[1000];

Random rnd = new Random();

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = rnd.Next(100,999);
    
}
foreach (int i in szamok)
{
    Console.Write(i+" ");   
}