using System;
class Program
{
    static void Main()
    {
        string[] komandy = {"Спартак", "ЦСКА", "Динамо", "Зенит", "Локомотив",
                           "Краснодар", "Ростов", "Ахмат", "Урал", "Крылья Советов",
                           "Сочи", "Нижний Новгород", "Уфа", "Химки", "Тамбов",
                           "Арсенал", "Рубин", "Оренбург", "СКА-Хабаровск", "Тосно"};

        int[] ochki = {70, 68, 65, 63, 61,
                      60, 59, 58, 57, 56,
                      55, 54, 53, 52, 51,
                      50, 49, 48, 47, 62};

        for (int i = 0; i < 19; i++)
        {
            for (int j = i + 1; j < 20; j++)
            {
                if (ochki[i] < ochki[j])
                {
                    int tempOchki = ochki[i];
                    ochki[i] = ochki[j];
                    ochki[j] = tempOchki;

                    string tempKomanda = komandy[i];
                    komandy[i] = komandy[j];
                    komandy[j] = tempKomanda;
                }
            }
        }

        Console.WriteLine("Места команд в чемпионате:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{i + 1}. {komandy[i]} - {ochki[i]} очков");
        }
    }
}