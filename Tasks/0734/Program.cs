using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, 25, 30, 47, 50, 63, 70, 88, 95, 100 };

        Console.WriteLine("а) Четные элементы:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                Console.WriteLine($"massiv[{i}] = {massiv[i]}");
            }
        }

        Console.WriteLine("б) Элементы, оканчивающиеся нулем:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 10 == 0)
            {
                Console.WriteLine($"massiv[{i}] = {massiv[i]}");
            }
        }
    }
}