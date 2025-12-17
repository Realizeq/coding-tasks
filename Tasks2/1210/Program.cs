using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов",
                           "Васильев", "Попов", "Соколов", "Михайлов", "Новиков",
                           "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев",
                           "Семенов", "Егоров", "Павлов", "Козлов", "Степанов",
                           "Николаев", "Орлов", "Андреев", "Макаров", "Никитин"};

        int[,] ocenki = {
            {5,4,5,4,5,4,5,4,5,4},
            {4,4,4,4,4,4,4,4,4,4},
            {3,3,3,3,3,3,3,3,3,3},
            {5,5,5,5,5,5,5,5,5,5},
            {4,5,4,5,4,5,4,5,4,5},
            {3,4,3,4,3,4,3,4,3,4},
            {5,4,5,4,5,4,5,4,5,4},
            {4,3,4,3,4,3,4,3,4,3},
            {5,5,4,5,5,4,5,5,4,5},
            {4,4,3,4,4,3,4,4,3,4},
            {5,3,5,3,5,3,5,3,5,3},
            {4,5,3,4,5,3,4,5,3,4},
            {3,4,5,3,4,5,3,4,5,3},
            {5,4,4,5,4,4,5,4,4,5},
            {4,3,5,4,3,5,4,3,5,4},
            {3,5,4,3,5,4,3,5,4,3},
            {5,4,3,5,4,3,5,4,3,5},
            {4,5,5,4,5,5,4,5,5,4},
            {3,3,4,3,3,4,3,3,4,3},
            {5,5,5,4,5,5,5,4,5,5},
            {4,4,4,5,4,4,4,5,4,4},
            {3,5,3,5,3,5,3,5,3,5},
            {5,3,4,3,5,3,4,3,5,3},
            {4,5,4,5,4,5,4,5,4,5},
            {3,4,3,4,3,4,3,4,3,4}
        };

        string novayaFamiliya = "Фомин";
        int[] novyeOcenki = { 4, 4, 5, 4, 5, 4, 4, 5, 4, 5 };
        int s = 10;

        Console.WriteLine("Таблица до добавления нового ученика:");
        for (int i = 0; i < 25; i++)
        {
            Console.Write($"{familii[i]}: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{ocenki[i, j]} ");
            }
            Console.WriteLine();
        }

        string[] novyeFamilii = new string[26];
        int[,] novyeOcenkiMassiv = new int[26, 10];

        for (int i = 0; i < s - 1; i++)
        {
            novyeFamilii[i] = familii[i];
            for (int j = 0; j < 10; j++)
            {
                novyeOcenkiMassiv[i, j] = ocenki[i, j];
            }
        }

        novyeFamilii[s - 1] = novayaFamiliya;
        for (int j = 0; j < 10; j++)
        {
            novyeOcenkiMassiv[s - 1, j] = novyeOcenki[j];
        }

        for (int i = s - 1; i < 25; i++)
        {
            novyeFamilii[i + 1] = familii[i];
            for (int j = 0; j < 10; j++)
            {
                novyeOcenkiMassiv[i + 1, j] = ocenki[i, j];
            }
        }

        Console.WriteLine("\nТаблица после добавления нового ученика:");
        for (int i = 0; i < 26; i++)
        {
            Console.Write($"{novyeFamilii[i]}: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{novyeOcenkiMassiv[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}