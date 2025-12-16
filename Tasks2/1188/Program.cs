using System;
class Program
{
    static void Main()
    {
        string[] zhurnaly = {"Журнал 1", "Журнал 2", "Журнал 3", "Журнал 4", "Журнал 5",
                            "Журнал 6", "Журнал 7", "Журнал 8", "Журнал 9", "Журнал 10",
                            "Журнал 11", "Журнал 12", "Журнал 13", "Журнал 14", "Журнал 15"};

        float[] ceny = {150, 200, 180, 250, 170,
                       220, 190, 210, 160, 230,
                       175, 240, 165, 195, 225};

        int[] tirazhi = {5000, 15000, 8000, 20000, 9500,
                        12000, 7500, 18000, 8500, 22000,
                        7000, 25000, 9000, 11000, 30000};

        float summa = 0;
        int count = 0;

        for (int i = 0; i < 15; i++)
        {
            if (tirazhi[i] < 10000)
            {
                summa += ceny[i];
                count++;
            }
        }

        if (count > 0)
        {
            float srednyaya = summa / count;
            Console.WriteLine($"Средняя стоимость журналов с тиражом <10000: {srednyaya:F2} руб");
            Console.WriteLine($"Количество таких журналов: {count}");
        }
        else
        {
            Console.WriteLine("Нет журналов с тиражом меньше 10000");
        }
    }
}