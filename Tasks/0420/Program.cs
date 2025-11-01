using System;
class Program
{
    static void Main()
    {
        double a1 = 0;
        double b1 = 1;
        double eps = 0.001;

        while (b1 - a1 > eps)
        {
            double c1 = (a1 + b1) / 2;
            double fc1 = Math.Pow(c1, 4) + 2 * Math.Pow(c1, 3) - c1 - 1;
            double fa1 = Math.Pow(a1, 4) + 2 * Math.Pow(a1, 3) - a1 - 1;

            if (fc1 * fa1 <= 0)
                b1 = c1;
            else
                a1 = c1;
        }
        double koren1 = (a1 + b1) / 2;
        Console.WriteLine($"а) корень {koren1:F2}");

        double a2 = 1;
        double b2 = 1.5;

        while (b2 - a2 > eps)
        {
            double c2 = (a2 + b2) / 2;
            double fc2 = Math.Pow(c2, 3) - 0.2 * Math.Pow(c2, 2) - 0.2 * c2 - 1.2;
            double fa2 = Math.Pow(a2, 3) - 0.2 * Math.Pow(a2, 2) - 0.2 * a2 - 1.2;

            if (fc2 * fa2 <= 0)
                b2 = c2;
            else
                a2 = c2;
        }
        double koren2 = (a2 + b2) / 2;
        Console.WriteLine($"б) корень {koren2:F2}");
    }
}