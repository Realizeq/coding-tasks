using System;
class Program
{
    static int SummaCifr(int n)
    {
        int s = 0;
        while (n > 0)
        {
            s += n % 10;
            n /= 10;
        }
        return s;
    }

    static bool Schastlivoe(int n)
    {
        int perv = n / 1000;
        int vtor = n % 1000;
        return SummaCifr(perv) == SummaCifr(vtor);
    }

    static void Main()
    {
        int schet = 0;

        for (int i = 100000; i <= 999999; i++)
        {
            if (Schastlivoe(i))
                schet++;
        }

        Console.WriteLine($"Количество счастливых чисел: {schet}");
    }
}