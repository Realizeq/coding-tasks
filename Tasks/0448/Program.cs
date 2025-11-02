using System;
class Program
{
    static void Main()
    {
        Console.Write("введите грузоподъемность автомобиля: ");
        int gruzopod = int.Parse(Console.ReadLine());

        int massa = 0;

        Console.Write("введите количество грузов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите массу груза {i}: ");
            int gruz = int.Parse(Console.ReadLine());
            massa += gruz;
        }

        if (massa > gruzopod) Console.WriteLine("превысила");
        else Console.WriteLine("не превысила");
    }
}