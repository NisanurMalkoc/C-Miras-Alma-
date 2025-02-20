using System;
class A
{
    public void Metot()
    {
        Console.WriteLine("A sınıfı");
    }
}
class B : A
{
    new public void Metot()
    {
        Console.WriteLine("B sınıfı");
    }
    static void Main()
    {
        A nesneA = new A();
        B nesneB = new B();
        nesneA = nesneB;
        nesneA.Metot();
    }
}
