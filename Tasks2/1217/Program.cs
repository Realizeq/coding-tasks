using System;
class Program
{
    static void Main()
    {
        string[] komandy = {"Спартак", "ЦСКА", "Динамо", "Зенит", "Локомотив",
                           "Краснодар", "Ростов", "Ахмат", "Урал", "Крылья Советов",
                           "Сочи", "Нижний Новгород", "Уфа", "Химки", "Тамбов", "Арсенал"};

        int[,] zabito = {
            {2,1,3,0,2,1,1,2,0,3,1,2,0,1,2},
            {1,2,1,3,0,2,1,0,3,2,1,3,0,2,1},
            {3,1,2,1,3,0,2,1,0,3,2,1,3,0,2},
            {0,3,1,2,1,3,0,2,1,0,3,2,1,3,0},
            {2,0,3,1,2,1,3,0,2,1,0,3,2,1,3},
            {1,3,0,2,1,2,1,3,0,2,1,0,3,2,1},
            {3,2,1,3,0,2,1,2,1,3,0,2,1,0,3},
            {0,1,3,0,2,1,3,1,2,0,3,1,2,1,0},
            {2,1,0,3,1,2,0,3,1,2,1,0,3,1,2},
            {1,0,2,1,3,0,2,1,3,0,2,1,3,0,2},
            {3,1,3,0,2,1,0,2,1,3,1,2,0,3,1},
            {0,2,1,2,0,3,1,0,2,1,3,0,2,1,3},
            {2,3,0,1,3,0,2,1,0,3,2,1,0,2,1},
            {1,2,1,3,0,2,1,3,0,2,1,3,0,2,1},
            {3,0,2,0,1,3,0,2,1,0,3,2,1,0,3},
            {0,1,3,2,1,0,3,0,2,1,0,3,2,1,0}
        };

        int[,] propusheno = {
            {1,2,0,3,1,0,2,1,3,0,2,1,3,0,2},
            {2,1,3,0,2,1,0,3,2,1,0,3,2,1,0},
            {0,3,1,2,0,3,1,2,1,0,3,2,1,0,3},
            {3,0,2,1,3,0,2,1,0,3,2,1,0,3,2},
            {1,3,0,2,1,3,0,2,1,0,3,2,1,0,3},
            {2,0,3,1,2,0,3,1,2,1,0,3,2,1,0},
            {0,1,2,0,3,1,2,0,3,1,2,0,3,1,2},
            {3,2,0,3,1,2,0,3,1,2,0,3,1,2,0},
            {1,0,3,1,2,0,3,1,2,0,3,1,2,0,3},
            {0,3,1,2,0,3,1,2,0,3,1,2,0,3,1},
            {2,1,0,3,1,2,1,0,3,1,2,0,3,1,2},
            {3,0,2,1,3,0,2,1,3,0,2,1,3,0,2},
            {1,2,1,0,2,1,0,3,2,1,0,3,2,1,0},
            {0,1,3,2,0,1,3,2,0,1,3,2,0,1,3},
            {2,3,0,1,2,3,0,1,2,3,0,1,2,3,0},
            {1,0,2,3,1,0,2,3,1,0,2,3,1,0,2}
        };

        int[,] tablica = new int[16, 16];
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                if (i != j)
                {
                    int pobeda = 0;
                    for (int k = 0; k < 15; k++)
                    {
                        if (zabito[i, k] > propusheno[i, k]) pobeda++;
                    }
                    tablica[i, j] = pobeda >= 8 ? 3 : (pobeda >= 5 ? 1 : 0);
                }
            }
        }

        int nichikh = 0;
        int raznost3 = 0;
        int[] pobedy = new int[16];
        int[] nichie = new int[16];
        int[] porazheniya = new int[16];
        int[] ochki = new int[16];

        for (int i = 0; i < 16; i++)
        {
            for (int k = 0; k < 15; k++)
            {
                if (zabito[i, k] == propusheno[i, k])
                {
                    nichikh++;
                    nichie[i]++;
                }
                else if (zabito[i, k] > propusheno[i, k])
                {
                    pobedy[i]++;
                }
                else
                {
                    porazheniya[i]++;
                }

                int razn = Math.Abs(zabito[i, k] - propusheno[i, k]);
                if (razn >= 3)
                {
                    raznost3++;
                }
            }
            ochki[i] = pobedy[i] * 3 + nichie[i];
        }

        Console.WriteLine("а) Таблица результатов (первые 5 команд):");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{tablica[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nб) Всего ничьих: {nichikh}");
        Console.WriteLine($"в) Игр с разностью мячей >=3: {raznost3}");

        Console.WriteLine("\nг) Статистика команд:");
        for (int i = 0; i < 16; i++)
        {
            Console.WriteLine($"{komandy[i]}: побед {pobedy[i]}, ничьих {nichie[i]}, поражений {porazheniya[i]}");
        }

        Console.WriteLine("\nд) Очки команд:");
        int maxOchki = 0;
        int indexChampion = 0;
        for (int i = 0; i < 16; i++)
        {
            Console.WriteLine($"{komandy[i]}: {ochki[i]} очков");
            if (ochki[i] > maxOchki)
            {
                maxOchki = ochki[i];
                indexChampion = i;
            }
        }

        Console.WriteLine($"\nе) Чемпион: {komandy[indexChampion]} - {ochki[indexChampion]} очков");
    }
}