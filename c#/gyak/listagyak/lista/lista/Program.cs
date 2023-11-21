using System;

List<string> lista = new List<string>();
lista.Add("Bence");
lista.Add("Ver Bulecz");
lista.Add("Vörös Bor");

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}
/*
foreach (string str in lista)
{
    Console.WriteLine(str);
}
*/
Console.WriteLine();
Console.WriteLine(lista.Contains("Bence"));
Console.WriteLine();
Console.WriteLine(lista.IndexOf("Bence"));
Console.WriteLine();
Console.WriteLine(lista.IndexOf("Vörös Bor"));
Console.WriteLine();
var a = lista[lista.IndexOf("Vörös Bor")][0];


Dictionary<string,int> p = new Dictionary<string,int>();
p.Add("Laci", 3);
p.Add("Bence", 0);
Console.WriteLine(p.Count);

p["Tomi"] = 4;
Console.WriteLine(p.Count);
try
{
    p.Add("Bence", 10);
}
catch (Exception)
{

    p["Bence"]--;
}