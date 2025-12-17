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

        float maxRost = 0;
        float minRost = float.MaxValue;
        int indexMax = -1;
        int indexMin = -1;

        for (int i = 0; i < 25; i++)
        {
            if (rost[i] > maxRost)
            {
                maxRost = rost[i];
                indexMax = i;
            }

            if (rost[i] < minRost)
            {
                minRost = rost[i];
                indexMin = i;
            }
        }

        Console.WriteLine($"а) Самый высокий: {familii[indexMax]} - {rost[indexMax]} см");
        Console.WriteLine($"   Самый низкий: {familii[indexMin]} - {rost[indexMin]} см");

        float max1 = 0;
        float max2 = 0;
        int index1 = -1;
        int index2 = -1;

        for (int i = 0; i < 25; i++)
        {
            if (rost[i] > max1)
            {
                max2 = max1;
                index2 = index1;
                max1 = rost[i];
                index1 = i;
            }
            else if (rost[i] > max2)
            {
                max2 = rost[i];
                index2 = i;
            }
        }

        Console.WriteLine($"б) Два самых высоких ученика (без учета самого высокого):");
        Console.WriteLine($"   1. {familii[index1]} - {rost[index1]} см");
        Console.WriteLine($"   2. {familii[index2]} - {rost[index2]} см");

        float pervый = 0;
        float vtorой = 0;
        int indexPervый = -1;
        int indexVtorой = -1;

        for (int i = 0; i < 25; i++)
        {
            if (rost[i] > pervый)
            {
                vtorой = pervый;
                indexVtorой = indexPervый;
                pervый = rost[i];
                indexPervый = i;
            }
            else if (rost[i] > vtorой)
            {
                vtorой = rost[i];
                indexVtorой = i;
            }
        }

        Console.WriteLine($"в) Два самых высоких ученика:");
        Console.WriteLine($"   1. {familii[indexPervый]} - {rost[indexPervый]} см");
        Console.WriteLine($"   2. {familii[indexVtorой]} - {rost[indexVtorой]} см");
    }
}