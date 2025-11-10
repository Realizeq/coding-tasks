using System;
class Program
{
    static void Main()
    {
        int max_people = 0;
        int max_apartment = 0;

        Console.Write("количество квартир: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"квартира {j}: ");
            int people = int.Parse(Console.ReadLine());

            if (people >= max_people)
            {
                max_people = people;
                max_apartment = j;
            }
        }

        Console.WriteLine($"квартира с максимальным количеством жильцов: {max_apartment}");
    }
}