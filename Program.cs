using Лабораторная_работа_1_вар_8;

class Program
{
    static void Main(string[] args)
    {
        Factory F1 = new Factory(7715680371, "Sinopec", 83, 22, "Pekin", 5122, 1314);
        F1.ToString();
        F1.GetInformation();
        Console.ReadLine();
    }
}