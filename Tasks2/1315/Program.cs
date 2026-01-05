using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int count = 0;
        int chislo;

        Console.WriteLine("Вводите неотрицательные числа, отрицательное для завершения:");

        while (true)
        {
            chislo = int.Parse(Console.ReadLine());
            if (chislo < 0)
                break;
            sum += chislo;
            count++;
        }

        if (count > 0)
        {
            float srednee = (float)sum / count;
            Console.WriteLine($"Среднее арифметическое: {srednee}");
        }
        else
        {
            Console.WriteLine("Нет чисел для подсчета");
        }
    }
}