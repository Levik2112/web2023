List<string> lista1 = new List<string>();
string[] lista2 = File.ReadAllLines("kiserlet.txt");
StreamReader olvas = new StreamReader("kiserlet.txt");
olvas.ReadLine();
while (!olvas.EndOfStream)
{
    lista1.Add(olvas.ReadLine());
}
olvas.Close();
for (int i = 0; i < lista1.Count; i++)
{
    Console.WriteLine(lista1[i]);
}

for(int i = 0; i < lista2.Length; i++)
{
  //Console.WriteLine(lista2[i]);
}