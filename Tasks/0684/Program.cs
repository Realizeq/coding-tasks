using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) 8 случайных чисел [0, 1):");
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(rand.NextDouble());
        }

        Console.WriteLine("б) k случайных чисел [0, 1):");
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(rand.NextDouble());
        }

        Console.WriteLine("в) 15 случайных чисел [25, 26):");
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(25 + rand.NextDouble());
        }

        Console.WriteLine("г) 20 случайных чисел [0, 15):");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(15 * rand.NextDouble());
        }

        Console.WriteLine("д) k чисел [0, b), где k <= a:");
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());
        int k_d = rand.Next(1, a + 1);
        Console.WriteLine($"k = {k_d}");
        for (int i = 0; i < k_d; i++)
        {
            Console.WriteLine(b * rand.NextDouble());
        }

        Console.WriteLine("е) 10 случайных чисел [-40, 40):");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(80 * rand.NextDouble() - 40);
        }

        Console.WriteLine("ж) k чисел [a, b), где k <= m:");
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        double a_g = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b_g = double.Parse(Console.ReadLine());
        int k_g = rand.Next(1, m + 1);
        Console.WriteLine($"k = {k_g}");
        for (int i = 0; i < k_g; i++)
        {
            Console.WriteLine(a_g + (b_g - a_g) * rand.NextDouble());
        }
    }
}