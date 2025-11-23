using System;
class Program
{
    static void Main()
    {
        int[] godRozhdeniya = { 1990, 1985, 1995, 1980, 1992, 1988, 1998, 1983, 1991, 1987, 1996 };

        int min1 = godRozhdeniya[0];
        int min2 = int.MaxValue;

        for (int i = 1; i < godRozhdeniya.Length; i++)
        {
            if (godRozhdeniya[i] < min1)
            {
                min2 = min1;
                min1 = godRozhdeniya[i];
            }
            else if (godRozhdeniya[i] < min2 && godRozhdeniya[i] != min1)
            {
                min2 = godRozhdeniya[i];
            }
        }

        Console.WriteLine($"Самый старший: {min1}");
        Console.WriteLine($"Второй самый старший: {min2}");
    }
}