using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) 10 случайных целых чисел [0, 10]:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(0, 11));
        }

        Console.WriteLine("б) k случайных целых чисел [0, a]:");
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(rand.Next(0, a + 1));
        }

        Console.WriteLine("в) 20 случайных целых чисел [10, 20]:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(rand.Next(10, 21));
        }

        Console.WriteLine("г) k случайных целых чисел [-10, a]:");
        Console.Write("Введите k: ");
        int k_g = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        int a_g = int.Parse(Console.ReadLine());
        for (int i = 0; i < k_g; i++)
        {
            Console.WriteLine(rand.Next(-10, a_g + 1));
        }

        Console.WriteLine("д) k чисел [a, b], где k <= 15:");
        Console.Write("Введите a: ");
        int a_d = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b_d = int.Parse(Console.ReadLine());
        int k_d = rand.Next(1, 16);
        Console.WriteLine($"k = {k_d}");
        for (int i = 0; i < k_d; i++)
        {
            Console.WriteLine(rand.Next(a_d, b_d + 1));
        }
    }
}