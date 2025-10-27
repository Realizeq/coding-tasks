using System;
class Program
{
    static void Main()
    {
        float length = 4.5f;
        float startDistance = 3.0f;

        for (float distance = startDistance; distance >= 0; distance -= 0.2f)
        {
            float angle = (float)(Math.Acos(distance / length) * 180 / Math.PI);

            Console.WriteLine($"Расстояние - {distance:f1}м, Угол - {angle:f1}");
        }
    }
}