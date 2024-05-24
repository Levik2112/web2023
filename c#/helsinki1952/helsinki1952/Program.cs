using helsinki1952;

List<adatok> eredmenyek = new List<adatok>();

StreamReader olvas = new StreamReader("helsinki.txt");
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    eredmenyek.Add(new adatok(sor));
}
olvas.Close();
Console.WriteLine("3.Feladat");
Console.WriteLine("Pontszerző helyezsek száma: {0}",eredmenyek.Count);

int[] ermekSzama = new int[7];

for (int i = 0; i < eredmenyek.Count; i++)
{
    ermekSzama[eredmenyek[i].helyezes]++;
}
Console.WriteLine("4. Feladat");
Console.WriteLine("Arany: {0}\nEzüst: {1}\nBronz: {2}\nÖsszesen: {3}", ermekSzama[1], ermekSzama[2], ermekSzama[3], ermekSzama[1]+ermekSzama[2]+ermekSzama[3]);

Console.WriteLine("5 Feladat");
Console.WriteLine("olimpiai pontok száma: {0}");