Console.Write("Krek egy szót: ");
string Be = Console.ReadLine();
bool joE = true;
string jok = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm-";
for(int i = 0; i < Be.Length; i++)
{
    if (jok.IndexOf(Be[i]) < 0)
    {
        Console.Write("Nem szó!");
        joE = false;
        break;
    }
}
if (joE)
{
    Console.WriteLine("{0}, jó szó!",Be);
}
//fordtitott kiiratas 1
string forditott = "";
for (int i = Be.Length-1;i >= 0; i--)
{
    forditott += Be[i];
}
Console.Write("A fordított szó: {0}",forditott);

//fordtitott kiiratas 2
/*
forditott = "";
for (int i = 0; i < Be.Length; i++)
{
    forditott += Be[Be.Length -1 - i];
}
Console.WriteLine(forditott);

forditott = "";
*/

//kettesével megforditás valami = milava
ujszo = "";
for (int i = 0;i < Be.Length; i+=2)
{ 
    ujszo += Be.Substring(Be.Length - 1 - 1-i, 2);
}
Console.WriteLine(ujszo);

//hf:melyik betudbol hany darab van kis nagy betuk egybe szamolva Aa = 2 aa = 2 AA = 2








