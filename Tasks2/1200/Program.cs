using System;
class Program
{
    static void Main()
    {
        string[] komandy = {"Спартак", "ЦСКА", "Динамо", "Зенит", "Локомотив",
                           "Краснодар", "Ростов", "Ахмат", "Урал", "Крылья Советов",
                           "Сочи", "Нижний Новгород", "Уфа", "Химки", "Тамбов",
                           "Арсенал", "Рубин", "Оренбург", "СКА-Хабаровск", "Тосно"};

        int[] ochki = {75, 70, 68, 65, 64,
                      63, 62, 61, 60, 59,
                      58, 57, 56, 55, 54,
                      53, 52, 51, 50, 49};

        int max1 = 0;
        int max2 = 0;
        int max3 = 0;
        int index1 = -1;
        int index2 = -1;
        int index3 = -1;

        for (int i = 0; i < 20; i++)
        {
            if (ochki[i] > max1)
            {
                max3 = max2;
                index3 = index2;
                max2 = max1;
                index2 = index1;
                max1 = ochki[i];
                index1 = i;
            }
            else if (ochki[i] > max2)
            {
                max3 = max2;
                index3 = index2;
                max2 = ochki[i];
                index2 = i;
            }
            else if (ochki[i] > max3)
            {
                max3 = ochki[i];
                index3 = i;
            }
        }

        Console.WriteLine($"а) Чемпион: {komandy[index1]} - {ochki[index1]} очков");
        Console.WriteLine($"б) Второе место: {komandy[index2]} - {ochki[index2]} очков");
        Console.WriteLine($"   Третье место: {komandy[index3]} - {ochki[index3]} очков");

        int perвое = 0;
        int vtoroe = 0;
        int indexPervoe = -1;
        int indexVtoroe = -1;

        for (int i = 0; i < 20; i++)
        {
            if (ochki[i] > perвое)
            {
                vtoroe = perвое;
                indexVtoroe = indexPervoe;
                perвое = ochki[i];
                indexPervoe = i;
            }
            else if (ochki[i] > vtoroe)
            {
                vtoroe = ochki[i];
                indexVtoroe = i;
            }
        }

        Console.WriteLine($"в) Первое место: {komandy[indexPervoe]} - {ochki[indexPervoe]} очков");
        Console.WriteLine($"   Второе место: {komandy[indexVtoroe]} - {ochki[indexVtoroe]} очков");
    }
}