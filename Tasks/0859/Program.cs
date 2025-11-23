using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("а) Увеличены в 2 раза:");
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] *= 2;
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Уменьшены на число A:");
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] -= A;
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Разделены на первый элемент:");
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] /= massiv[0];
            Console.WriteLine($"{massiv[i]}");
        }
    }
}