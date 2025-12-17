using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидорова", "Кузнецов", "Смирнова",
                           "Васильев", "Попова", "Соколов", "Михайлова", "Новиков",
                           "Федорова", "Морозов", "Волкова", "Алексеев", "Лебедева",
                           "Семенов", "Егорова", "Павлов", "Козлова", "Степанов"};

        float[] zarplata = {50000, 60000, 45000, 70000, 48000,
                          55000, 42000, 65000, 46000, 75000,
                          44000, 58000, 43000, 62000, 47000,
                          54000, 41000, 63000, 45000, 59000};

        bool[] pol = {true, true, false, true, false,
                     true, false, true, false, true,
                     false, true, false, true, false,
                     true, false, true, false, true};

        float maxZarplataMuzh = 0;
        int indexMaxMuzh = -1;

        float minZarplataMuzh = float.MaxValue;
        float minZarplataZhen = float.MaxValue;
        int indexMinMuzh = -1;
        int indexMinZhen = -1;

        for (int i = 0; i < 20; i++)
        {
            if (pol[i])
            {
                if (zarplata[i] > maxZarplataMuzh)
                {
                    maxZarplataMuzh = zarplata[i];
                    indexMaxMuzh = i;
                }

                if (zarplata[i] < minZarplataMuzh)
                {
                    minZarplataMuzh = zarplata[i];
                    indexMinMuzh = i;
                }
            }
            else
            {
                if (zarplata[i] < minZarplataZhen)
                {
                    minZarplataZhen = zarplata[i];
                    indexMinZhen = i;
                }
            }
        }

        Console.WriteLine($"а) Мужчина с самой большой зарплатой: {familii[indexMaxMuzh]} - {zarplata[indexMaxMuzh]} руб");

        Console.WriteLine($"б) Мужчина с самой маленькой зарплатой: {familii[indexMinMuzh]} - {zarplata[indexMinMuzh]} руб");
        Console.WriteLine($"Женщина с самой маленькой зарплатой: {familii[indexMinZhen]} - {zarplata[indexMinZhen]} руб");
    }
}