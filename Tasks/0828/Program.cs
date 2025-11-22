using System;

class Program
{
    static void Main()
    {
        int[] godRozhdeniya = { 1990, 1985, 1995, 1980, 1992, 1988, 1998, 1983, 1991, 1987, 1996, };

        int max = godRozhdeniya[0];
        int min = godRozhdeniya[0];

        for (int i = 1; i < godRozhdeniya.Length; i++)
        {
            if (godRozhdeniya[i] > max)
            {
                max = godRozhdeniya[i];
            }
            if (godRozhdeniya[i] < min)
            {
                min = godRozhdeniya[i];
            }
        }

        int raznica = max - min;

        Console.WriteLine($"Самый старший старше самого младшего на: {raznica} лет");
    }
}