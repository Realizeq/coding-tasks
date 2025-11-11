using System;
class Program
{
    static void Main()
    {
        float a = 1.2f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Числа которые больше a:");

        int n = 2;

        while (true)
        {
            float chislo = 1.0f + 1.0f / n;

            if (chislo < a)
                break;

            Console.WriteLine($"1 + 1/{n} = {chislo}");
            n++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        for (int i = 2; i <= 20; i++)
        {
            float summa = 1.0f + 1.0f / i;
            if (summa >= a)
                Console.WriteLine($"1 + 1/{i} = {summa}");
            else
                break;
        }

        Console.WriteLine();

        Console.WriteLine("Третий вариант:");

        int chisloN = 2;
        float tekushayaSumma;

        do
        {
            tekushayaSumma = 1.0f + 1.0f / chisloN;
            if (tekushayaSumma >= a)
                Console.WriteLine($"1 + 1/{chisloN} = {tekushayaSumma}");
            chisloN++;
        }
        while (tekushayaSumma >= a);
    }
}