using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.Write("количество студентов: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"студент {i} - экзамен 1: ");
            int exam1 = int.Parse(Console.ReadLine());

            Console.Write($"студент {i} - экзамен 2: ");
            int exam2 = int.Parse(Console.ReadLine());

            if (exam1 == 2 || exam2 == 2) count++;
        }

        Console.WriteLine($"студентов с двойкой: {count}");
    }
}