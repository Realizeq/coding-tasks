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

        Console.WriteLine("а) Поменяны половины:");
        int polovina = massiv.Length / 2;
        for (int i = 0; i < polovina; i++)
        {
            int temp = massiv[i];
            massiv[i] = massiv[i + polovina];
            massiv[i + polovina] = temp;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Поменяны соседние элементы:");
        for (int i = 0; i < massiv.Length; i += 2)
        {
            int temp = massiv[i];
            massiv[i] = massiv[i + 1];
            massiv[i + 1] = temp;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Поменяны зеркально:");
        for (int i = 0; i < massiv.Length / 2; i++)
        {
            int temp = massiv[i];
            massiv[i] = massiv[massiv.Length - 1 - i];
            massiv[massiv.Length - 1 - i] = temp;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}