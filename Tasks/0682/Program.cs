using System;
class Program
{
    static void Main()
    {
        int n = 1;
        bool found = false;

        while (!found)
        {
            int ways = 0;

            for (int a = 1; a * a * a < n; a++)
            {
                for (int b = a + 1; b * b * b < n; b++)
                {
                    if (a * a * a + b * b * b == n)
                    {
                        ways++;
                    }
                }
            }

            if (ways >= 2)
            {
                Console.WriteLine($"Наименьшее число: {n}");
                for (int a = 1; a * a * a < n; a++)
                {
                    for (int b = a + 1; b * b * b < n; b++)
                    {
                        if (a * a * a + b * b * b == n)
                        {
                            Console.WriteLine($"Кубы:{a} + {b} = {n}");
                        }
                    }
                }
                found = true;
            }

            n++;
        }
    }
}