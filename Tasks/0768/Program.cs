using System;
class Program
{
    static void Main()
    {
        double[] balli = { 5.8, 5.9, 5.7, 5.8, 5.9, 5.8, 5.9, 6.0, 5.8, 5.9, 6.0, 5.8, 5.9, 6.0, 5.8, 5.9, 6.0, 5.9 };

        double obyazatelnaya = 0;
        double proizvolnaya = 0;

        for (int i = 0; i < 6; i++)
        {
            obyazatelnaya += balli[i];
        }

        for (int i = 6; i < 18; i++)
        {
            proizvolnaya += balli[i];
        }

        if (obyazatelnaya > proizvolnaya)
        {
            Console.WriteLine("Лучший результат в обязательной программе");
        }
        else if (proizvolnaya > obyazatelnaya)
        {
            Console.WriteLine("Лучший результат в произвольной программе");
        }
        else
        {
            Console.WriteLine("Результаты одинаковые");
        }
    }
}