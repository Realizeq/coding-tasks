using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int index = 0;
        while (index < massiv.Length && massiv[index] <= n)
        {
            index++;
        }

        if (index < massiv.Length)
        {
            Console.WriteLine("Элементы после первого большего n:");
            for (int i = index; i < massiv.Length; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
        else
        {
            Console.WriteLine($"Нет элементов больше {n}");
        }
    }
}