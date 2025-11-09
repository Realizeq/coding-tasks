using System;
class Program
{
    static void Main()
    {
        double sum_car = 0;
        double sum_moto = 0;
        int count_car = 0;
        int count_moto = 0;

        Console.Write("количество автомобилей: ");
        int n_car = int.Parse(Console.ReadLine());

        Console.Write("количество мотоциклов: ");
        int n_moto = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n_car; i++)
        {
            Console.Write($"автомобиль {i}: ");
            double price = double.Parse(Console.ReadLine());
            sum_car += price;
            count_car++;
        }

        for (int i = 1; i <= n_moto; i++)
        {
            Console.Write($"мотоцикл {i}: ");
            double price = double.Parse(Console.ReadLine());
            sum_moto += price;
            count_moto++;
        }

        double average_car = sum_car / count_car;
        double average_moto = sum_moto / count_moto;

        if (average_car > average_moto * 3) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}