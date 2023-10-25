//kerjunk be szavakat ne lgeyen beene szokoz v specialis karakter és ezeket szavanként irjuk bele egy fileba

string betuk = "qwertzuiopőúöüóasdfghjkléáűmnbvcxyí-";

string beSzo = "qwe";
string gyujto = "";
while (beSzo!="")
{
    bool joSzo = true;


    Console.Write("Kérek egy szót: ");
    beSzo =Console.ReadLine();

    for (int i = 0; i < beSzo.Length; i++)
    {
            if (betuk.IndexOf(beSzo[i]) == -1)
            {
                joSzo = false;
                Console.WriteLine("Nem jó szó!");
                break;
            }
    }
    if (joSzo)
    {
        gyujto += beSzo+" ";
    }
}
Console.WriteLine(gyujto);
string[] darabok = gyujto.Trim().Split(' ');

StreamWriter ir = new StreamWriter("szavak.txt");
for (int i = 0;i < darabok.Length; i++)
{
    ir.WriteLine(darabok[i]);
}
ir.Close();
File.WriteAllLines("szavak2.txt", darabok);