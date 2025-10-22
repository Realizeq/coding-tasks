using System;
class Program
{
    static void Main()
    {
        float distanceFromHome = 0.0f;
        float totalPath = 0.0f;
        int direction = 1;

        for (int n = 1; n <= 100; n++)
        {
            float step = 1.0f / n;
            distanceFromHome += direction * step;
            totalPath += step;
            direction *= -1;
        }

        Console.WriteLine($"а) {distanceFromHome:f1} км от дома");
        Console.WriteLine($"б) {totalPath:f1} км общий путь");
    }
}