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
            tulaj = value;
        }
    }
}
class Program
{
    static void Main()
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.kerekSzam);
        kocsi.dudal();
        kocsi.tulajdonos = "gabui";
        Console.WriteLine(kocsi.tulajdonos);
    }
}