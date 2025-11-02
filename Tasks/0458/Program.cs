using System;
class Program
{
    static void Main()
    {
        Console.Write("количество предметов: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"масса предмета {i}: ");
            double massa = double.Parse(Console.ReadLine());
            sum += massa;
        }

        double srednee = sum / n;
        Console.WriteLine($"средняя масса: {srednee}");
    }
}