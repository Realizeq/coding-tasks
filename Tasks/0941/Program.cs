using System;
class Program
{
    static void Main()
    {
        int[] zabito = { 2, 1, 3, 0, 2, 1, 1, 2, 0, 3, 1, 2, 0, 1, 2, 1, 0, 2, 1, 1 };
        int[] propusheno = { 1, 1, 2, 2, 1, 0, 2, 2, 0, 2, 1, 1, 1, 0, 1, 2, 1, 1, 0, 2 };

        int win = 0;
        int lose = 0;
        int draw = 0;
        int raznost3 = 0;
        int ochki = 0;

        for (int i = 0; i < 20; i++)
        {
            if (zabito[i] > propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: выигрыш");
                win++;
                ochki += 3;
            }
            else if (zabito[i] < propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: проигрыш");
                lose++;
            }
            else
            {
                Console.WriteLine($"Игра {i + 1}: ничья");
                draw++;
                ochki += 1;
            }

            int razn = zabito[i] - propusheno[i];
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