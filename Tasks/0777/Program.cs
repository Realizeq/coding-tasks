using System;
class Program
{
    static void Main()
    {
        int[] zhiteli = { 25, 30, 28, 32, 26, 35, 24, 31, 27, 33, 29, 34, 23, 36, 25, 37, 26, 38, 24, 39 };

        int summaNechetnyh = 0;
        int summaChetnyh = 0;

        for (int i = 0; i < zhiteli.Length; i++)
        {
            if (i % 2 == 0)
            {
                summaNechetnyh += zhiteli[i];
            }
            else
            {
                summaChetnyh += zhiteli[i];
            }
        }

        if (summaNechetnyh > summaChetnyh)
        {
            Console.WriteLine("Больше жителей на стороне с нечетными номерами");
        }
        else if (summaChetnyh > summaNechetnyh)
        {
            Console.WriteLine("Больше жителей на стороне с четными номерами");
        }
        else
        {
            Console.WriteLine("Жителей одинаково на обеих сторонах");
        }
    }
}