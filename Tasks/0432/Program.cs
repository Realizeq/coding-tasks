using System;
class Program
{
    static void Main()
    {
        double massa = 0;

        Console.Write("введите количество предметов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите массу предмета {i}: ");
            double predmet = double.Parse(Console.ReadLine());
            massa += predmet;
        }

        Console.WriteLine($"общая масса груза: {massa}");
    }
}