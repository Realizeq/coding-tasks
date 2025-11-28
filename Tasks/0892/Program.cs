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

        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        int elementS = massiv[s - 1];
        for (int i = s - 1; i > k - 1; i--)
        {
            massiv[i] = massiv[i - 1];
        }
        massiv[k - 1] = elementS;

        Console.WriteLine("После перестановки:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}