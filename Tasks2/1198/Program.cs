using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов",
                           "Васильев", "Попов", "Соколов", "Михайлов", "Новиков",
                           "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев",
                           "Семенов", "Егоров", "Павлов", "Козлов", "Степанов",
                           "Николаев", "Орлов"};

        int[,] ocenki = {
            {5,4,5,4}, {4,4,4,4}, {3,3,3,3}, {5,5,5,5}, {4,5,4,5},
            {3,4,3,4}, {5,4,5,4}, {4,3,4,3}, {5,5,4,5}, {4,4,3,4},
            {5,3,5,3}, {4,5,3,4}, {3,4,5,3}, {5,4,4,5}, {4,3,5,4},
            {3,5,4,3}, {5,4,3,5}, {4,5,5,4}, {3,3,4,3}, {5,5,5,4},
            {4,4,4,5}, {3,5,3,5}
        };

        int maxSumma = 0;
        int indexMax = -1;

        for (int i = 0; i < 22; i++)
        {
            int summa = 0;
            for (int j = 0; j < 4; j++)
            {
                summa += ocenki[i, j];
            }

            if (summa > maxSumma)
            {
                maxSumma = summa;
                indexMax = i;
            }
        }

        Console.WriteLine($"Ученик с максимальной суммой оценок: {familii[indexMax]}");
        Console.WriteLine($"Сумма оценок: {maxSumma}");
        Console.WriteLine($"Оценки: {ocenki[indexMax, 0]}, {ocenki[indexMax, 1]}, {ocenki[indexMax, 2]}, {ocenki[indexMax, 3]}");
    }
}