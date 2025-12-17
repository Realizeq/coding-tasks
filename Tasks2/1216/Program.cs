using System;
class Program
{
    static void Main()
    {
        string[] komandy = {"Спартак", "ЦСКА", "Динамо", "Зенит", "Локомотив",
                           "Краснодар", "Ростов", "Ахмат", "Урал", "Крылья Советов",
                           "Сочи", "Нижний Новгород", "Уфа", "Химки", "Тамбов",
                           "Арсенал", "Рубин", "Оренбург", "СКА-Хабаровск", "Тосно"};

        int[,] tablica = {
            {0,3,1,0,3,1,3,0,1,3,1,0,3,1,0,3,1,0,3,1},
            {0,0,3,1,0,3,1,3,0,1,3,1,0,3,1,0,3,1,0,3},
            {1,0,0,3,1,0,3,1,3,0,1,3,1,0,3,1,0,3,1,0},
            {3,1,0,0,3,1,0,3,1,3,0,1,3,1,0,3,1,0,3,1},
            {0,3,1,0,0,3,1,0,3,1,3,0,1,3,1,0,3,1,0,3},
            {1,0,3,1,0,0,3,1,0,3,1,3,0,1,3,1,0,3,1,0},
            {0,1,0,3,1,0,0,3,1,0,3,1,3,0,1,3,1,0,3,1},
            {3,0,1,0,3,1,0,0,3,1,0,3,1,3,0,1,3,1,0,3},
            {1,3,0,1,0,3,1,0,0,3,1,0,3,1,3,0,1,3,1,0},
            {0,1,3,0,1,0,3,1,0,0,3,1,0,3,1,3,0,1,3,1},
            {1,0,1,3,0,1,0,3,1,0,0,3,1,0,3,1,3,0,1,3},
            {3,1,0,1,3,0,1,0,3,1,0,0,3,1,0,3,1,3,0,1},
            {0,3,1,0,1,3,0,1,0,3,1,0,0,3,1,0,3,1,3,0},
            {1,0,3,1,0,1,3,0,1,0,3,1,0,0,3,1,0,3,1,3},
            {3,1,0,3,1,0,1,3,0,1,0,3,1,0,0,3,1,0,3,1},
            {0,3,1,0,3,1,0,1,3,0,1,0,3,1,0,0,3,1,0,3},
            {1,0,3,1,0,3,1,0,1,3,0,1,0,3,1,0,0,3,1,0},
            {3,1,0,3,1,0,3,1,0,1,3,0,1,0,3,1,0,0,3,1},
            {0,3,1,0,3,1,0,3,1,0,1,3,0,1,0,3,1,0,0,3},
            {1,0,3,1,0,3,1,0,3,1,0,1,3,0,1,0,3,1,0,0}
        };

        int[] ochki = new int[20];

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                ochki[i] += tablica[i, j];
            }
        }

        Console.WriteLine("а) Команды с большим количеством побед, чем проигрышей:");
        for (int i = 0; i < 20; i++)
        {
            int pobedy = 0;
            int porazheniya = 0;
            for (int j = 0; j < 20; j++)
            {
                if (tablica[i, j] == 3) pobedy++;
                if (tablica[i, j] == 0 && i != j) porazheniya++;
            }
            if (pobedy > porazheniya)
            {
                Console.WriteLine($"{komandy[i]}");
            }
        }

        Console.WriteLine("\nб) Команды без проигрышей:");
        for (int i = 0; i < 20; i++)
        {
            bool bezPorazheniy = true;
            for (int j = 0; j < 20; j++)
            {
                if (tablica[i, j] == 0 && i != j)
                {
                    bezPorazheniy = false;
                    break;
                }
            }
            if (bezPorazheniy)
            {
                Console.WriteLine($"{komandy[i]}");
            }
        }

        int maxOchki = 0;
        int indexChampion = 0;
        for (int i = 0; i < 20; i++)
        {
            if (ochki[i] > maxOchki)
            {
                maxOchki = ochki[i];
                indexChampion = i;
            }
        }
        Console.WriteLine($"\nв) Чемпион: {komandy[indexChampion]} - {ochki[indexChampion]} очков");

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

                    int[,] tempTablica = new int[20, 20];
                    for (int k = 0; k < 20; k++)
                    {
                        for (int l = 0; l < 20; l++)
                        {
                            tempTablica[k, l] = tablica[i, l];
                        }
                    }
                    for (int k = 0; k < 20; k++)
                    {
                        for (int l = 0; l < 20; l++)
                        {
                            tablica[i, l] = tablica[j, l];
                        }
                    }
                    for (int k = 0; k < 20; k++)
                    {
                        for (int l = 0; l < 20; l++)
                        {
                            tablica[j, l] = tempTablica[k, l];
                        }
                    }
                }
            }
        }

        Console.WriteLine("\nг) Команды в соответствии с занятыми местами:");
        bool pravilno = true;
        for (int i = 0; i < 19; i++)
        {
            if (ochki[i] < ochki[i + 1])
            {
                pravilno = false;
                Console.WriteLine($"Нарушение порядка у команды: {komandy[i]}");
                break;
            }
        }
        if (pravilno)
        {
            Console.WriteLine("Команды расположены правильно");
        }

        Console.WriteLine("\nд) Команды по местам:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{i + 1}. {komandy[i]} - {ochki[i]} очков");
        }
    }
}