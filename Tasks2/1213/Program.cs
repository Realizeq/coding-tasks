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

        string novayaKomanda = "Тосно";
        int ochkiNovoy = 62;

        string[] novyeKomandy = new string[20];
        int[] novyeOchki = new int[20];

        int i = 0;
        while (i < 19 && ochki[i] > ochkiNovoy)
        {
            novyeKomandy[i] = komandy[i];
            novyeOchki[i] = ochki[i];
            i++;
        }

        novyeKomandy[i] = novayaKomanda;
        novyeOchki[i] = ochkiNovoy;

        while (i < 19)
        {
            novyeKomandy[i + 1] = komandy[i];
            novyeOchki[i + 1] = ochki[i];
            i++;
        }

        Console.WriteLine("Новый список команд по убыванию очков:");
        for (int j = 0; j < 20; j++)
        {
            Console.WriteLine($"{j + 1}. {novyeKomandy[j]} - {novyeOchki[j]} очков");
        }
    }
}