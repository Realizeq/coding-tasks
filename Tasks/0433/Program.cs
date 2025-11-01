using System;
class Program
{
    static void Main()
    {
        double summa = 0;

        Console.Write("введите количество сотрудников: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите зарплату сотрудника {i}: ");
            double zarplata = double.Parse(Console.ReadLine());
            summa += zarplata;
        }

        Console.WriteLine($"общая сумма выплат: {summa}");
    }
}