using System;
class Program
{
    static void Main()
    {
        int[] zhyteli = {50000, 75000, 100000, 125000, 150000, 175000, 200000, 225000, 250000, 275000,
                        300000, 325000, 350000, 375000, 400000, 425000, 450000, 475000, 500000, 525000,
                        550000, 575000, 600000, 625000, 650000, 675000, 700000, 725000, 750000, 600000};

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < zhyteli.Length; i++)
        {
            Console.WriteLine($"{zhyteli[i]}");
        }

        int poslednii = zhyteli[zhyteli.Length - 1];
        int poziciya = zhyteli.Length - 1;
        while (poziciya > 0 && poslednii < zhyteli[poziciya - 1])
        {
            zhyteli[poziciya] = zhyteli[poziciya - 1];
            poziciya--;
        }
        zhyteli[poziciya] = poslednii;

        Console.WriteLine("После упорядочивания:");
        for (int i = 0; i < zhyteli.Length; i++)
        {
            Console.WriteLine($"{zhyteli[i]}");
        }
    }
}