using System;
class Program
{
    static void Main()
    {
        int m = 16;
        int g = 2;
        int z = 2;

        if (m == g)
        {
            Console.WriteLine("является");
            return;
        }

        if (z == 1)
        {
            if (m == g)
            {
                Console.WriteLine("является");
            }
            else
            {
                Console.WriteLine("нне является");
            }
            return;
        }

        double temp = (double)m / g;

        while (temp > 1)
        {
            temp = temp / z;
        }

        if (Math.Abs(temp - 1) < 0.0001)
        {
            Console.WriteLine("является");
        }
        else
        {
            Console.WriteLine("не является");
        }
    }
}