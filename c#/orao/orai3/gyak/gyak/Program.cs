// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//.WriteLine(15/10.0);
/*
//3 szám bekérése irassuk ki a legnagyobbat
//kérjetek be egy számot és egy betut és annyiszor irjuk ki amennyi a szám
//be 2 szám a 2 szám nlgyzeteinek összegét számoljuk ki
//2 szám közti számok közti négyzeteinek összege
//négyzetgyökvonás

//1.feladat
Console.Write("Kérem az első számot: ");
int szami= Convert.ToInt32(Console.ReadLine());
Console.Write("Kérem a második számot: ");
int szamb = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérem a harmadik számot: ");
int szamk = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(szami);
//Console.WriteLine(szamb);
//Console.WriteLine(szamk);
int legnagyobbSzam = Math.Max(szamk, Math.Max(szami, szamb));
Console.WriteLine($"A legnagyobb szám: {legnagyobbSzam}");


//1.feladat vége
//2.feladat
Console.Write("Kérek egy számot: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérek egy betűt: ");
char bet = Convert.ToChar(Console.ReadLine());

//Console.WriteLine(bet);
//Console.WriteLine(bet*a);

for (int i = 0; i < a; i++)
{
    Console.Write(bet);
}
//2.feladat vége
Console.WriteLine();  
//3.feladat
Console.Write("Kérek egy számot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérek egy számot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());
Console.Write((szam1*szam1)+(szam2*szam2));

//3.feladat vége
//4.feladat
int osszeg = 0;
if (szam1 > szam2)
{
    for (int i = szam2; i < szam1; i++)
    {
        osszeg += i * i;
    }
}
else 
{
    for (int i = szam1; i < szam2; i++)
    {
        osszeg += i * i;
    }
}


Console.WriteLine(osszeg);
//4.feladat vége
*/
int x = 10;
Console.WriteLine((x*x+3*x)/9);
Console.WriteLine((x - 5*(x * x)));
Console.WriteLine(x-6*(9-x)*2);
Console.WriteLine(x + 12 + 6);
