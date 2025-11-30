using System;
class Program
{
    static void Main()
    {
        int[] igri = { 21, 11, 32, 02, 21, 10, 12, 22, 00, 32, 11, 21, 01, 10, 21, 12, 01, 21, 10, 12 };

        int win = 0;
        int lose = 0;
        int draw = 0;
        int raznost3 = 0;
        int ochki = 0;

        for (int i = 0; i < 20; i++)
        {
            int zabito = igri[i] / 10;
            int propusheno = igri[i] % 10;

            if (zabito > propusheno)
            {
                Console.WriteLine($"Игра {i + 1}: выигрыш {zabito}-{propusheno}");
                win++;
                ochki += 3;
            }
            else if (zabito < propusheno)
            {
                Console.WriteLine($"Игра {i + 1}: проигрыш {zabito}-{propusheno}");
                lose++;
            }
            else
            {
                Console.WriteLine($"Игра {i + 1}: ничья {zabito}-{propusheno}");
                draw++;
                ochki += 1;
            }

            int razn = zabito - propusheno;
            if (razn >= 3 || razn <= -3)
            {
                raznost3++;
            }
        }

        Console.WriteLine($"Выигрышей: {win}");
        Console.WriteLine($"Проигрышей: {lose}");
        Console.WriteLine($"Ничьих: {draw}");
        Console.WriteLine($"Игр с разностью >=3: {raznost3}");
        Console.WriteLine($"Всего очков: {ochki}");
    }
}