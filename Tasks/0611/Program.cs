using System;
class Program
{
    static void Main()
    {
        float a = 0.3f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Числа которые больше a:");

        int znam = 1;

        while (true)
        {
            float chislo = 1.0f / znam;

            if (chislo < a)
                break;

            Console.WriteLine($"1/{znam} = {chislo}");
            znam++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        int maxZnam = (int)(1 / a);

        for (int i = 1; i <= maxZnam; i++)
        {
            float drob = 1.0f / i;
            Console.WriteLine($"1/{i} = {drob}");
        }

        Console.WriteLine();

        Console.WriteLine("Третий вариант:");

        int n = 1;
        float tek;

        do
        {
            tek = 1.0f / n;
            if (tek >= a)
                Console.WriteLine($"1/{n} = {tek}");
            n++;
        }
        while (tek >= a);
    }
}