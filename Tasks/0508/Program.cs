using System;
class Program
{
    static void Main()
    {
        int win = 0;
        int draw = 0;
        int lose = 0;
        int diff3 = 0;
        int points = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"игра {i} - забито: ");
            int scored = int.Parse(Console.ReadLine());

            Console.Write($"игра {i} - пропущено: ");
            int missed = int.Parse(Console.ReadLine());

            // а)
            if (scored > missed)
            {
                Console.WriteLine("выигрыш");
                win++;
                points += 3;
            }
            else if (scored == missed)
            {
                Console.WriteLine("ничья");
                draw++;
                points += 1;
            }
            else
            {
                Console.WriteLine("проигрыш");
                lose++;
            }

            // д)
            if (scored - missed >= 3) diff3++;
        }

        // б)
        Console.WriteLine($"выигрышей: {win}");

        // в)
        Console.WriteLine($"выигрышей: {win}, проигрышей: {lose}");

        // г)
        Console.WriteLine($"выигрышей: {win}, ничьих: {draw}, проигрышей: {lose}");

        // д)
        Console.WriteLine($"игр с разностью >= 3: {diff3}");

        // е)
        Console.WriteLine($"очков: {points}");
    }
}