using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("100 подбрасываний:");
        int orly100 = 0;
        int reshki100 = 0;

        for (int i = 0; i < 100; i++)
        {
            int moneta = rand.Next(0, 2);
            if (moneta == 0)
            {
                orly100++;
            }
            else
            {
                reshki100++;
            }
        }

        Console.WriteLine($"Орлов: {orly100} ({orly100 / 100.0})");
        Console.WriteLine($"Решек: {reshki100} ({reshki100 / 100.0})");

        Console.WriteLine("1000 подбрасываний:");
        int orly1000 = 0;
        int reshki1000 = 0;

        for (int i = 0; i < 1000; i++)
        {
            int moneta = rand.Next(0, 2);
            if (moneta == 0)
            {
                orly1000++;
            }
            else
            {
                reshki1000++;
            }
        }

        Console.WriteLine($"Орлов: {orly1000} ({orly1000 / 1000.0})");
        Console.WriteLine($"Решек: {reshki1000} ({reshki1000 / 1000.0})");
    }
}