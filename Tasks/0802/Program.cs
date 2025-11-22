using System;
class Program
{
    static void Main()
    {
        int[] rost = { 165, -172, 158, -180, 168, -175, 162, -178, 170, -167, 173, -160, 181, -169, 176, -163, 179, -171, 166, -174, 161, -177 };

        int summaMalchikov = 0;
        int countMalchikov = 0;
        int summaDevochek = 0;
        int countDevochek = 0;

        for (int i = 0; i < rost.Length; i++)
        {
            if (rost[i] < 0)
            {
                summaMalchikov += Math.Abs(rost[i]);
                countMalchikov++;
            }
            else
            {
                summaDevochek += rost[i];
                countDevochek++;
            }
        }

        if (countMalchikov > 0)
        {
            double sredneeMalchikov = (double)summaMalchikov / countMalchikov;
            Console.WriteLine($"Средний рост мальчиков: {sredneeMalchikov}");
        }

        if (countDevochek > 0)
        {
            double sredneeDevochek = (double)summaDevochek / countDevochek;
            Console.WriteLine($"Средний рост девочек: {sredneeDevochek}");
        }
    }
}