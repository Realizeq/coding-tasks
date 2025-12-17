using System;
class Program
{
    static void Main()
    {
        string[] predmety = {"Математика", "Физика", "Химия", "Биология", "История",
                            "Литература", "Русский язык", "Иностранный язык", "География", "Информатика",
                            "Обществознание", "Физкультура"};

        int[,] ocenki = {
            {5,4,5,4,5,4,5,4,5,4,5,4},
            {4,4,4,4,4,4,4,4,4,4,4,4},
            {3,3,3,3,3,3,3,3,3,3,3,3},
            {5,5,5,5,5,5,5,5,5,5,5,5},
            {4,5,4,5,4,5,4,5,4,5,4,5},
            {3,4,3,4,3,4,3,4,3,4,3,4},
            {5,4,5,4,5,4,5,4,5,4,5,4},
            {4,3,4,3,4,3,4,3,4,3,4,3},
            {5,5,4,5,5,4,5,5,4,5,5,4},
            {4,4,3,4,4,3,4,4,3,4,4,3},
            {5,3,5,3,5,3,5,3,5,3,5,3},
            {4,5,3,4,5,3,4,5,3,4,5,3},
            {3,4,5,3,4,5,3,4,5,3,4,5},
            {5,4,4,5,4,4,5,4,4,5,4,4},
            {4,3,5,4,3,5,4,3,5,4,3,5},
            {3,5,4,3,5,4,3,5,4,3,5,4},
            {5,4,3,5,4,3,5,4,3,5,4,3},
            {4,5,5,4,5,5,4,5,5,4,5,5},
            {3,3,4,3,3,4,3,3,4,3,3,4},
            {5,5,5,4,5,5,5,4,5,5,5,4},
            {4,4,4,5,4,4,4,5,4,4,4,5},
            {3,5,3,5,3,5,3,5,3,5,3,5},
            {5,3,4,3,5,3,4,3,5,3,4,3}
        };

        string novyiPredmet = "ОБЖ";
        int[] ocenkiNovogoPredmeta = { 5, 4, 3, 5, 4, 3, 5, 4, 3, 5, 4, 3, 5, 4, 3, 5, 4, 3, 5, 4, 3, 5, 4 };
        int k = 8;

        Console.WriteLine("Таблица до добавления нового предмета:");
        Console.Write("Предметы: ");
        for (int j = 0; j < 12; j++)
        {
            Console.Write($"{predmety[j]} ");
        }
        Console.WriteLine("\n");

        for (int i = 0; i < 23; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.Write($"{ocenki[i, j]} ");
            }
            Console.WriteLine();
        }

        string[] novyePredmety = new string[13];
        int[,] novyeOcenki = new int[23, 13];

        for (int j = 0; j < k - 1; j++)
        {
            novyePredmety[j] = predmety[j];
            for (int i = 0; i < 23; i++)
            {
                novyeOcenki[i, j] = ocenki[i, j];
            }
        }

        novyePredmety[k - 1] = novyiPredmet;
        for (int i = 0; i < 23; i++)
        {
            novyeOcenki[i, k - 1] = ocenkiNovogoPredmeta[i];
        }

        for (int j = k - 1; j < 12; j++)
        {
            novyePredmety[j + 1] = predmety[j];
            for (int i = 0; i < 23; i++)
            {
                novyeOcenki[i, j + 1] = ocenki[i, j];
            }
        }

        Console.WriteLine("\nТаблица после добавления нового предмета:");
        Console.Write("Предметы: ");
        for (int j = 0; j < 13; j++)
        {
            Console.Write($"{novyePredmety[j]} ");
        }
        Console.WriteLine("\n");

        for (int i = 0; i < 23; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Console.Write($"{novyeOcenki[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}