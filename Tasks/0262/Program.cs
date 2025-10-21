using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Фунты   Кг");

        for (int i = 1; i <= 10; i++)
        {
            float kg = i * 0.453f;
            Console.WriteLine($"{i,-6}  {kg,-6:F3} ");
        }
    }
}