// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Feladat
Console.Write("Kérem az első számot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Kérem az második számot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());

int szam3 = szam1 + szam2;

Console.WriteLine("Az eredményed: "+szam3*szam3);


//2. Feladat
Console.Write("Kérem a szót/szavakat: ");
string szavak = Console.ReadLine();
string vegjel = "";