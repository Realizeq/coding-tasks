using System;
class Program
{
    static void Main()
    {
        double obsh = 0;

        Console.Write("введите количество элементов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите сопротивление элемента {i}: ");
            double r = double.Parse(Console.ReadLine());
            obsh += 1 / r;
        }

        double soprotivlenie = 1 / obsh;
        Console.WriteLine($"общее сопротивление цепи: {soprotivlenie}");
    }
}