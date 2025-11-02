using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"оценка ученика {i}: ");
            double ocenka = double.Parse(Console.ReadLine());
            sum += ocenka;
        }

        double srednee = sum / 20;
        Console.WriteLine($"средняя оценка: {srednee}");
    }
}