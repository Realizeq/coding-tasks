using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 37, 0, 50, 46, 34, 46, 0, 13 };

        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}