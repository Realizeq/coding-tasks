using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) Вещественные [0, 1):");
        double[] massivA = new double[15];
        for (int i = 0; i < 15; i++)
        {
            massivA[i] = rand.NextDouble();
            Console.WriteLine($"[{i}] = {massivA[i]}");
        }

        Console.WriteLine("б) Вещественные [22, 23):");
        double[] massivB = new double[15];
        for (int i = 0; i < 15; i++)
        {
            massivB[i] = 22 + rand.NextDouble();
            Console.WriteLine($"[{i}] = {massivB[i]}");
        }

        Console.WriteLine("в) Вещественные [0, 10):");
        double[] massivV = new double[15];
        for (int i = 0; i < 15; i++)
        {
            massivV[i] = 10 * rand.NextDouble();
            Console.WriteLine($"[{i}] = {massivV[i]}");
        }

        Console.WriteLine("г) Вещественные [-50, 50):");
        double[] massivG = new double[15];
        for (int i = 0; i < 15; i++)
        {
            massivG[i] = 100 * rand.NextDouble() - 50;
            Console.WriteLine($"[{i}] = {massivG[i]}");
        }

        Console.WriteLine("д) Целые [0, 10]:");
        int[] massivD = new int[15];
        for (int i = 0; i < 15; i++)
        {
            massivD[i] = rand.Next(0, 11);
            Console.WriteLine($"[{i}] = {massivD[i]}");
        }
    }
}