using System;
class Program
{
    static void Main()
    {
        int[] zabito = { 2, 1, 3, 0, 2, 1, 1, 2, 0, 3, 1, 2, 0, 1, 2, 1, 0, 2, 1, 1, 3, 2 };
        int[] propusheno = { 1, 1, 2, 2, 1, 0, 2, 2, 0, 2, 1, 1, 1, 0, 1, 2, 1, 1, 0, 2, 1, 1 };

        int win = 0;
        int lose = 0;
        int draw = 0;
        int ochki = 0;

        Console.WriteLine("а) Результаты игр:");
        for (int i = 0; i < 22; i++)
        {
            if (zabito[i] > propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: {zabito[i]}-{propusheno[i]} - выигрыш");
                win++;
                ochki += 3;
            }
            else if (zabito[i] < propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: {zabito[i]}-{propusheno[i]} - проигрыш");
                lose++;
            }
            else
            {
                Console.WriteLine($"Игра {i + 1}: {zabito[i]}-{propusheno[i]} - ничья");
                draw++;
                ochki += 1;
            }
        }

        Console.WriteLine($"\nб) Выигрышей: {win}");
        Console.WriteLine($"в) Выигрышей: {win}, проигрышей: {lose}");
        Console.WriteLine($"г) Выигрышей: {win}, ничьих: {draw}, проигрышей: {lose}");
        Console.WriteLine($"д) Всего очков: {ochki}");
    }
}