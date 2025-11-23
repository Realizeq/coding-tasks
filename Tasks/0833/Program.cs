using System;
class Program
{
    static void Main()
    {
        int[] godRozhdeniya = { 1990, 1985, 1995, 1980, 1992, 1988, 1998, 1983, 1991, 1987 };

        int min = godRozhdeniya[0];
        int indexFirst = 0;
        int indexLast = 0;

        for (int i = 1; i < godRozhdeniya.Length; i++)
        {
            if (godRozhdeniya[i] < min)
            {
                min = godRozhdeniya[i];
                indexFirst = i;
                indexLast = i;
            }
            else if (godRozhdeniya[i] == min)
            {
                indexLast = i;
            }
        }

        Console.WriteLine($"а) Первый самый старший: {indexFirst + 1}");
        Console.WriteLine($"б) Последний самый старший: {indexLast + 1}");
    }
}