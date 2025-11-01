using System;
class Program
{
    static void Main()
    {
        double soprotivlenie = 0;

        Console.Write("введите количество элементов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите сопротивление элемента {i}: ");
            double element = double.Parse(Console.ReadLine());
            soprotivlenie += element;
        }

        Console.WriteLine($"общее сопротивление цепи: {soprotivlenie}");
    }
}