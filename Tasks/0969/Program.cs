using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название государства: ");
        string state = Console.ReadLine();

        Console.Write("Введите название столицы: ");
        string capital = Console.ReadLine();

        Console.WriteLine($"Столица государства {state} – город {capital}");
    }
}