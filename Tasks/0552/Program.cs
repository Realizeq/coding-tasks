using System;
class Program
{
    static void Main()
    {
        int position = 0;
        int[] ochki = new int[20];

        Console.WriteLine("очки 20 команд (по убыванию):");
        for (int j = 0; j < 20; j++)
        {
            ochki[j] = int.Parse(Console.ReadLine());
        }

        Console.Write("очки команды: ");
        int N = int.Parse(Console.ReadLine());

        int k = 0;
        while (ochki[k] != N)
        {
            k++;
        }
        position = k + 1;

        Console.WriteLine($"место команды: {position}");
    }
}