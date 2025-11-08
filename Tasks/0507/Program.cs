using System;
class Program
{
    static void Main()
    {
        int win = 0;
        int lose = 0;
        int draw = 0;

        Console.Write("количество игр: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"игра {i} - очки: ");
            int points = int.Parse(Console.ReadLine());

            if (points == 3) win++;
            else if (points == 1) draw++;
            else if (points == 0) lose++;
        }

        Console.WriteLine($"выигрышей: {win}");
        Console.WriteLine($"ничьих: {draw}");
        Console.WriteLine($"проигрышей: {lose}");
    }
}