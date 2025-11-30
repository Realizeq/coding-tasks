using System;
class Program
{
    static void Main()
    {
        float[] rasstoyanie = { 120, 80, 150, 90, 200, 110, 170, 95, 130, 85, 180, 100, 140, 75, 160, 105, 125, 70, 190, 115, 135, 88, 165, 98, 145 };
        float[] vremya = { 2, 1.5f, 2.5f, 1.8f, 3.2f, 2.1f, 2.8f, 1.7f, 2.3f, 1.6f, 3.0f, 1.9f, 2.4f, 1.4f, 2.7f, 2.0f, 2.2f, 1.3f, 3.1f, 2.1f, 2.5f, 1.7f, 2.9f, 1.8f, 2.6f };

        float minSkorost = float.MaxValue;

        for (int i = 0; i < 25; i++)
        {
            float skorost = rasstoyanie[i] / vremya[i];
            if (skorost < minSkorost)
            {
                minSkorost = skorost;
            }
        }

        Console.WriteLine($"Минимальная средняя скорость: {minSkorost} км/ч");

        float[] skorosti = new float[25];
        float minSkorost2 = float.MaxValue;

        for (int i = 0; i < 25; i++)
        {
            skorosti[i] = rasstoyanie[i] / vremya[i];
            if (skorosti[i] < minSkorost2)
            {
                minSkorost2 = skorosti[i];
            }
        }

        Console.WriteLine($"Минимальная средняя скорость (способ 2): {minSkorost2} км/ч");
    }
}