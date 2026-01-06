using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a (1 < a <= 1.5): ");
        float a = float.Parse(Console.ReadLine());

        int n = 2;
        float chislo = 1 + 1.0f / n;

        while (chislo >= a)
        {
            Console.WriteLine($"n = {n}");
            n++;
            chislo = 1 + 1.0f / n;
        }
    }
}