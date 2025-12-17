using System;
class Program
{
    static void Main()
    {
        string[] komandy = {"Спартак", "ЦСКА", "Динамо", "Зенит", "Локомотив",
                           "Краснодар", "Ростов", "Ахмат", "Урал", "Крылья Советов",
                           "Сочи", "Нижний Новгород", "Уфа", "Химки", "Тамбов",
                           "Арсенал", "Рубин", "Оренбург", "СКА-Хабаровск"};

        int[] ochki = {70, 68, 65, 63, 61,
                      60, 59, 58, 57, 56,
                      55, 54, 53, 52, 51,
                      50, 49, 48, 47};

        int ochkiNovoyKomandy = 62;
        string nazvanieNovoyKomandy = "Тосно";

        int mesto = 1;
        int i = 0;
        while (i < 19 && ochki[i] > ochkiNovoyKomandy)
        {
            mesto++;
            i++;
        }

        Console.WriteLine($"а) Команда '{nazvanieNovoyKomandy}' заняла {mesto} место");

        Console.WriteLine($"\nб) Команды, набравшие меньше очков, чем '{nazvanieNovoyKomandy}':");
        while (i < 19)
        {
            Console.WriteLine($"{komandy[i]} - {ochki[i]} очков");
            i++;
        }
    }
}