using System;
class Program
{
    static void Main()
    {
        int[] massiv = new int[20];

        for (int i = 0; i < 20; i++)
        {
            massiv[i] = 20 - i;
        }
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}