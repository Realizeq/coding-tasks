using System;
class program
{
    static void Main()
    {
        Console.Write("Введите массу в килограммах: ");
        int kg = Convert.ToInt32(Console.ReadLine());

        int centners = kg / 100;

        Console.WriteLine($"Полных центнеров: {centners}");
    }
}