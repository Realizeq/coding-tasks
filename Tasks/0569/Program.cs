using System;
class Program
{
    static void Main()
    {
        double max_diagonal = 0;

        Console.Write("количество квадратов: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"квадрат {j} - площадь: ");
            double area = double.Parse(Console.ReadLine());

            double side = Math.Sqrt(area);
            double diagonal = side * Math.Sqrt(2);

            if (diagonal > max_diagonal) max_diagonal = diagonal;
        }

        Console.WriteLine($"диагональ самого большого: {max_diagonal}");
    }
}