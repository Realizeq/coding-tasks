using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("а) Уменьшены на 20:");
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] -= 20;
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Умножены на последний элемент:");
        int poslednii = massiv[massiv.Length - 1];
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] *= poslednii;
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Увеличены на число B:");
        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] += B;
            Console.WriteLine($"{massiv[i]}");
        }
    }
}