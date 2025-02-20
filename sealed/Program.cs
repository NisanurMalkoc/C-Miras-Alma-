class Sinif
{
    public string  Metot()
    {
        return "Deneme";
    }
}
class yavru :Sinif
{
    static void Main()
    {
        Sinif s = new Sinif();
        Console.WriteLine(s.Metot());
        Console.WriteLine(Metot());
        Console.WriteLine("bu bir denemedir");

    }
}