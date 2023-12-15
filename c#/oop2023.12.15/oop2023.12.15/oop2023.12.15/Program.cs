using oop2023._12._15;
using System;

class auto
{
    public int kerekSzam = 4;
    public void dudal()
    {
        Console.WriteLine("tütütütü!");
    }
    private string tulaj;
    public string tulajdonos
    {
        get
        {
            return tulaj;
        }
        set
        {
            if (value == "Bence")
            {
                Console.WriteLine("EZT NEM");
            }
            else
            {
                tulaj = value;
            }

        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.kerekSzam);
        kocsi.dudal();
        kocsi.tulajdonos = "gabui";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Bence";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Ákos";
        Console.WriteLine(kocsi.tulajdonos);

        laci laci = new laci();
        laci.sug();
    }
}