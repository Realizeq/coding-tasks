using System;

class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов",
                           "Васильев", "Попов", "Соколов", "Михайлов", "Новиков",
                           "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев",
                           "Семенов", "Егоров", "Павлов", "Козлов", "Степанов"};

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
            {5,5,5,4,5,5,5,4,5,5,5,4}
        };

        float[] srednieUchenikov = new float[20];
        float obshayaSumma = 0;

        for (int i = 0; i < 20; i++)
        {
            float summa = 0;
            for (int j = 0; j < 12; j++)
            {
                summa += ocenki[i, j];
            }
            srednieUchenikov[i] = summa / 12;
            obshayaSumma += srednieUchenikov[i];
        }

        float srednyayaKlassa = obshayaSumma / 20;

        Console.WriteLine("Средние оценки учеников:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{familii[i]}: {srednieUchenikov[i]:F2}");
        }

        Console.WriteLine($"\nСредняя оценка по классу: {srednyayaKlassa:F2}");

        Console.WriteLine("\nУченики со средней оценкой выше средней по классу:");
        for (int i = 0; i < 20; i++)
        {
            if (srednieUchenikov[i] > srednyayaKlassa)
            {
                Console.WriteLine($"{familii[i]}: {srednieUchenikov[i]:F2}");
            }
        }
    }
}