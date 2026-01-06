using System;
class Program
{
    static void Main()
    {
        int nashlo = 0;
        int tek = 2;

        Console.WriteLine("Первые 100 простых чисел:");

        while (nashlo < 100)
        {
            bool prostoe = true;
            for (int del = 2; del <= Math.Sqrt(tek); del++)
            {
                if (tek % del == 0)
                {
                    prostoe = false;
                    break;
                }
            }

            if (prostoe)
            {
                Console.WriteLine(tek);
                nashlo++;
            }
            tek++;
        }
    }
}