void kiir(int[] tomb)
{
    foreach (int i in tomb)
    {
        Console.WriteLine("{0}. szám", i);
    }
}

int[] szamok = new int[100];
for (int i = 1; i < szamok.Length; i++)
{
    szamok[i] = i+1;
}
/*
foreach (int i in szamok)
{
    Console.WriteLine("{0}. szám",i);
}
*/


for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = szamok[i] * 2;
}

kiir(szamok);

//hf:a szorzo tabla 1-10ig megvalositasa 2dimenzios tombbel és kiirasa táblázat szeruen