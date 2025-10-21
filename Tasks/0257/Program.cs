using System;
class Program
{
    static void Main()
    {
        // все целые числа от 20 до 35
        Console.WriteLine("а) Числа от 20 до 35:");
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }

        // квадраты всех целых чисел от a до 50
        Console.Write("б) Введите a (a <= 50): ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Квадраты чисел от {a} до 50:");
        for (int i = a; i <= 50; i++)
        {
            Console.WriteLine(i * i);
        }

        // кубы всех целых чисел от 10 до b
        Console.Write("в) Введите b (b >= 10): ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Кубы чисел от 10 до {b}:");
        for (int i = 10; i <= b; i++)
        {
            Console.WriteLine(i * i * i);
        }

        // все целые числа от a до b
        Console.Write("г) Введите a: ");
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("Введите b (b >= a): ");
        int b2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Числа от {a2} до {b2}:");
        for (int i = a2; i <= b2; i++)
        {
            Console.WriteLine(i);
        }
    }
}