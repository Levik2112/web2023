// See https://aka.ms/new-console-template for more information
//számokat bekérni amig 1,2-el nem oszthato a szám utánna annak a számnk az egész részének irassátok ki az osztoit
Console.Write("Kérek egy számot: ");
double szam = Convert.ToDouble(Console.ReadLine());
while (szam %1.2>=0.01)
{
    Console.Write("Kérek egy számot: ");
    szam=Convert.ToDouble(Console.ReadLine());
}
int szam2 = (int)szam;
Console.WriteLine(szam2);
