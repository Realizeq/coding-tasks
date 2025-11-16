using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        double tochnost = 0.0001;
        double piPred = 0;
        double piTek = 0;
        long tochek = 0;
        long popalo = 0;

        do
        {
            piPred = piTek;

            for (int i = 0; i < 10000; i++)
            {
                double x = rand.NextDouble() * 2 - 1;
                double y = rand.NextDouble() * 2 - 1;

                if (x * x + y * y <= 1)
                {
                    popalo++;
                }
                tochek++;
            }

            piTek = 4.0 * popalo / tochek;
        }
        while (Math.Abs(piTek - piPred) > tochnost);

        Console.WriteLine($"pi = {piTek}");
        Console.WriteLine($"Количество точек: {tochek}");
    }
}