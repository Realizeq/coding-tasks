using System;
class Program
{
    static void Main()
    {
        int even = 0;
        int odd = 0;

        Console.Write("количество домов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"дом {i}: ");
            int people = int.Parse(Console.ReadLine());

            if (i % 2 == 0) even += people;
            else odd += people;
        }

        if (odd > even) Console.WriteLine("нечетная");
        else if (even > odd) Console.WriteLine("четная");
        else Console.WriteLine("одинаково");
    }
}