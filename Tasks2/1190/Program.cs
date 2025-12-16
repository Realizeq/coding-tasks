using System;
class Program
{
    static void Main()
    {
        float[] rost = {175, 182, 165, 180, 168, 178, 170, 185, 172, 167,
                       179, 164, 183, 169, 176, 171, 184, 166, 177, 173,
                       181, 174};

        bool[] pol = {true, true, false, true, false, true, false, true, true, false,
                     true, false, true, false, true, false, true, true, false, true,
                     true, false};

        float summaRost = 0;
        int countMuzhchin = 0;

        for (int i = 0; i < 22; i++)
        {
            if (pol[i])
            {
                summaRost += rost[i];
                countMuzhchin++;
            }
        }

        if (countMuzhchin > 0)
        {
            float sredniyRost = summaRost / countMuzhchin;
            Console.WriteLine($"Средний рост мужчин: {sredniyRost:F1} см");
            Console.WriteLine($"Количество мужчин: {countMuzhchin}");
        }
        else
        {
            Console.WriteLine("Нет мужчин в списке");
        }
    }
}