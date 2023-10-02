// See https://aka.ms/new-console-template for more information
//formázott kiiratás

/*

Console.WriteLine("szoveg {0:0.00%} szoveg {1,10}---",12,3.4);

int a = 1;
double b = 3.4;
Console.WriteLine($"szoveg {a} szoveg {b}");

Console.WriteLine("{0,10}",1);
Console.WriteLine("{0,10}", 10);
Console.WriteLine("{0,10}", 100);
Console.WriteLine("{0,10}", 1000);
*/
/*
int a = 3;
int b = 4;
double c=Math.Sqrt(a*a + b*b);
Console.WriteLine(c);
for (int i = 0; i < 50; i++)
{
    for (int k = 0; k < 50; k++)
    c=Math.Sqrt(i*i + k*k);
    if (c %1== 0)
    {
        Console.WriteLine("{0,5 {1,5}{2,5}", i,k, c);
    }
}
*/
for (int i = 0; i <10; i++)
{
    Console.WriteLine("{0:0.00}",Math.Sqrt(i));
}