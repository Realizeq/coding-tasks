using System;
class Program
{
    static void Main()
    {
        int max_people = 0;
        int count = 0;

        Console.Write("количество квартир: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"квартира {j}: ");
            int people = int.Parse(Console.ReadLine());

            if (people > max_people)
            {
                max_people = people;
                count = 1;
            }
            else if (people == max_people)
            {
                count++;
            }
        }

        Console.WriteLine($"квартир с максимальным количеством жильцов: {count}");
    }
}