using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Удален третий элемент:");
        for (int i = 2; i < massiv.Length - 1; i++)
        {
            massiv[i] = massiv[i + 1];
        }
        massiv[massiv.Length - 1] = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Удален k-й элемент:");
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        for (int i = k; i < massiv.Length - 1; i++)
        {
            massiv[i] = massiv[i + 1];
        }
        massiv[massiv.Length - 1] = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}