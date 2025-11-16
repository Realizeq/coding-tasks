using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) Площадь под половиной синусоиды:");
        int tochek = 100000;
        int popalo = 0;

        for (int i = 0; i < tochek; i++)
        {
            double x = rand.NextDouble() * Math.PI;
            double y = rand.NextDouble();

            if (y <= Math.Sin(x))
            {
                popalo++;
            }
        }

        double ploshadSin = (double)popalo / tochek * Math.PI;
        Console.WriteLine($"Площадь: {ploshadSin}");

        Console.WriteLine("б) Площадь под параболой y = x^2 от 0 до 3:");
        popalo = 0;

        for (int i = 0; i < tochek; i++)
        {
            double x = rand.NextDouble() * 3;
            double y = rand.NextDouble() * 9;

            if (y <= x * x)
            {
                popalo++;
            }
        }

        double ploshadParabola = (double)popalo / tochek * 27;
        Console.WriteLine($"Площадь: {ploshadParabola}");
    }
}