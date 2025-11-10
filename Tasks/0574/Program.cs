using System;
class Program
{
    static void Main()
    {
        int max = 0;
        int min = int.MaxValue;

        for (int j = 1; j <= 20; j++)
        {
            Console.Write($"класс {j}: ");
            int students = int.Parse(Console.ReadLine());

            if (students > max) max = students;
            if (students < min) min = students;
        }

        int difference = max - min;
        Console.WriteLine($"разница: {difference} учеников");
    }
}