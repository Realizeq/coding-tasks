using System;
class Program
{
    static void Main()
    {
        int[] massiv = new int[12];

        for (int i = 0; i < 12; i++)
        {
            massiv[i] = i + 1;
        }
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}