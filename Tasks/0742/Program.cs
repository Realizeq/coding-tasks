using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Console.WriteLine("Элементы на четных местах:");
        for (int i = 1; i < massiv.Length; i += 2)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("Элементы на нечетных местах:");
        for (int i = 0; i < massiv.Length; i += 2)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}