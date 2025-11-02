using System;
class Program
{
    static void Main()
    {
        double sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"оценка по предмету {i}: ");
            double ocenka = double.Parse(Console.ReadLine());
            sum += ocenka;
        }

        double srednee = sum / 10;
        Console.WriteLine($"средняя оценка: {srednee}");
    }
}