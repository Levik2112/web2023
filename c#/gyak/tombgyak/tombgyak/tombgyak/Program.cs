//csinaljunk egy fuggvenyt ami vissza ad a parametereknek megadott tombot
/*
int[] tombKeszit(int darab,int legkisebb,int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i=0;i<tomb.Length;i++)
    {
        tomb[i] = rand.Next(legkisebb,legnagyobb+1);
    }
    return tomb;
}
int[] szamok = tombKeszit(1000, 100, 999);
int parosDB = 0;
int paratlanDB = 0;
for (int i=0; i < szamok.Length; i++)
{
    if (szamok[i] %2 == 0)
    {
        parosDB++;
    }
    else
    {
        paratlanDB++;
    }
}
Console.WriteLine("Ennyi páros van: {0}",parosDB);
Console.WriteLine();
Console.WriteLine("Ennyi páratlab van: {0}",paratlanDB);
Console.WriteLine();

//kovetkezo elem vizsgalata
bool vanEgyenloSzomszedos=false;
for (int  i = 0;  i < szamok.Length-1;  i++)
{
    if (szamok[i] == szamok[i+1])
    {
        vanEgyenloSzomszedos = true;
        break;
    }
}
if (vanEgyenloSzomszedos)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem!");
}
Console.WriteLine();

//elozo elem vizsgalata
bool vanEgyenloSzomszedos1 = false;
for (int i = 1; i < szamok.Length; i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        vanEgyenloSzomszedos1 = true;
        //break;
        Console.WriteLine("Egyenlő: {0}. és {1}, {2} = {3}", i - 1, i, szamok[i - 1], szamok[i]);
        Console.WriteLine();
    }
}

if (vanEgyenloSzomszedos1)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem!");
}
*/
/*
void szakasKeres(int[] szamTomb)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i < szamTomb.Length; i++)
    {
        if (szamTomb[i - 1] < szamTomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;

        }
    }
    Console.WriteLine();  

    Console.Write("A legnagyobb növekvő számsorozat {0} elemű ", maxVeg-maxKezd+1);
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.Write("{0}, ", szamTomb[i]);
    } 
}


szakasKeres(szamok);
*/

//legnagyobb csokkeno sorozatot adja vissza és nem szigoruan csokkeno az egyenloseg még beleszamit
//NEM JÓ
/*
void szakasKeres(int[] szamTomb)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i > szamTomb.Length; i++)
    {
        if (szamTomb[i - 1] < szamTomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;

        }
    }
    Console.WriteLine();

    Console.Write("A legnagyobb növekvő számsorozat {0} elemű ", maxVeg - maxKezd + 1);
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.Write("{0}, ", szamTomb[i]);
    }
}
*/
//fuggveny ami vissza ad 1 10000tagu 4jegyu pozitiv száokat tartalmazo tombot
//keressuk meg az olyan pontosan 3 tagu szakaszokat amik egymastol max 10 távolságra vannak

int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }
    return tomb;
}
int[] szamok = tombKeszit(10000, 1000, 9999);

