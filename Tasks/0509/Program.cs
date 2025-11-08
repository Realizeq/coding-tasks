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
            Console.Write($"игра {i}: ");
            int result = int.Parse(Console.ReadLine());

            int scored = result / 10;
            int missed = result % 10;

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

            if (scored - missed >= 3) diff3++;
        }

        Console.WriteLine($"выигрышей: {win}");
        Console.WriteLine($"выигрышей: {win}, проигрышей: {lose}");
        Console.WriteLine($"выигрышей: {win}, ничьих: {draw}, проигрышей: {lose}");
        Console.WriteLine($"игр с разностью >= 3: {diff3}");
        Console.WriteLine($"очков: {points}");
    }
}