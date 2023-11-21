static string szo(int db)
{
    Random rand = new Random();
    string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
    string mgh = "aeiouöüóűáéáíő";
    string msh = "bcdfghkljmnpqrstvwyzxq";

    string szo = "";
    int eltol = rand.Next(2);
    for (int i = 0; i < db; i++)
    {
        //int index = rand.Next(betuk.Length);
        //szo += betuk[index];
        if ((i+eltol)%2==0)
        {
            int index = rand.Next(mgh.Length);
            szo += mgh[index];
        }
        else
        {

            int index = rand.Next(msh.Length);
            szo += msh[index];
        }
        
    }
    return szo;
    /*
    string szo = "";
    for (int i = 0; i < db; i++)
    {
        int index = rand.Next(betuk.Length);
        szo += betuk[index];
    }
    return szo;
    */
}

string[] sokSzo = new string[10000];
Random rand = new Random();
for (int i = 0;i < sokSzo.Length; i++)
{
    sokSzo[i] = szo(rand.Next(2, 11));
    
}
/* DEBUG
sokSzo[sokSzo.Length - 1] = "aaaa";
sokSzo[0] = "baaaab";
*/
File.WriteAllLines("szavak.txt", sokSzo);
/* kiiratas
for  (int i = 0; i < sokSzo.Length; i++)
{
    Console.WriteLine(sokSzo[i]);
}
*/
string[] szavak = File.ReadAllLines("szavak.txt");
//tobb elem keresese
string tobbSzoros = "";
for (int i = 0;i<szavak.Length; i++)
{
    for (int j = i+1;j < szavak.Length; j++)
    {
        if (szavak[i] == szavak[j])
        {
            tobbSzoros += ";"+szavak[j];
            break;
        }
    }
}

if (tobbSzoros != "")
{
    tobbSzoros = tobbSzoros.Substring(1);
    Console.WriteLine("Többször előforduló elemek: "+tobbSzoros);
}

//4 betus kereses
for (int i = 0; i < sokSzo.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        szavak[i] = szavak[i].Substring(0, 1).ToUpper()+szavak[i].Substring(1);
        //Console.WriteLine(szavak[i]);
    }
}

//4 betus ami benne van egy 6 betusben
/*
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length==4)
    {
        for (int k = 0; k < szavak.Length; k++)
        {
            if (szavak[k].Length == 6)
            {
                if (szavak[k].IndexOf(szavak[i].ToLower())>-1)
                {
                    Console.WriteLine("{0} benne van ebben: {1}", szavak[i], szavak[k]);
                }
            }
        }
    }
}
*/
//5 betus szavakban betuk kicserelese
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length==5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o","0");
        //Console.WriteLine(szavak[i]);
    }
}
//a szavak hosszusag szerinti tagolasa es abc rendben valo kiiratasa
string[] valogat = new string[11];
for (int i = 0; i < szavak.Length; i++)
{
    valogat[szavak[i].Length] += szavak[i] + ";";
}
//Console.WriteLine(valogat[6]); Console.WriteLine(valogat[5]); Console.WriteLine(valogat[4]);

for (int i = 2; i < valogat.Length; i++)
{
    string[] darabolt = valogat[i].Substring(0, valogat[i].Length - 1).Split(';');
    Array.Sort(darabolt);
    File.WriteAllLines(i+"betus.txt", darabolt);
}


