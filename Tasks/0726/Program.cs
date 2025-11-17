using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) Убывающая последовательность:");
        int[] massivA = new int[8];

        for (int i = 0; i < 8; i++)
        {
            massivA[i] = 100 - i * 10;
        }

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine($"[{i}] = {massivA[i]}");
        }

        Console.WriteLine("б) Возрастающая последовательность:");
        int[] massivB = new int[8];

        for (int i = 0; i < 8; i++)
        {
            massivB[i] = i * 5 + 10;
        }

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine($"[{i}] = {massivB[i]}");
        }
    }
}