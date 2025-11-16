using System;
class Program
{
    static void Main()
    {
        int[] massiv = new int[27];

        for (int i = 0; i < 25; i++)
        {
            massiv[i] = i + 1;
        }
        massiv[25] = 100;
        massiv[26] = 200;
        for (int i = 0; i < 27; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}