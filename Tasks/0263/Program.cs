using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Дюймы   Сантиметры");

        for (int inches = 10; inches <= 22; inches++)
        {
            float cm = inches * 2.54f;
            Console.WriteLine($"{inches,-6}  {cm,-10:F2}");
        }
    }
}