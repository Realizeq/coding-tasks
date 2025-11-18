using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, -5, 23, 8, -15, 30, 7, -9, 42, -3 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Является ли s-й элемент положительным:");
        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());
        if (massiv[s] > 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

        Console.WriteLine("б) Является ли k-й элемент четным:");
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        if (massiv[k] % 2 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

        Console.WriteLine("в) Какой элемент больше: k-й или s-й:");
        if (massiv[k] > massiv[s])
        {
            Console.WriteLine("k-й элемент больше");
        }
        else if (massiv[s] > massiv[k])
        {
            Console.WriteLine("s-й элемент больше");
        }
        else
        {
            Console.WriteLine("Элементы равны");
        }
    }
}