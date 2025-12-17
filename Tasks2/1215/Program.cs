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

        float[] rost = {175, 182, 165, 180, 168, 178, 170, 185, 172, 167,
                       179, 164, 183, 169, 176, 171, 184, 166, 177, 173,
                       181, 174, 186, 187, 188};

        for (int i = 0; i < 24; i++)
        {
            for (int j = i + 1; j < 25; j++)
            {
                if (rost[i] > rost[j])
                {
                    float tempRost = rost[i];
                    rost[i] = rost[j];
                    rost[j] = tempRost;

                    string tempFamiliya = familii[i];
                    familii[i] = familii[j];
                    familii[j] = tempFamiliya;
                }
            }
        }

        Console.WriteLine("Ученики в порядке возрастания роста:");
        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine($"{familii[i]} - {rost[i]} см");
        }
    }
}