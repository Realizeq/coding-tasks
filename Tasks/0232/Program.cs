using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество очков: ");
        int points = int.Parse(Console.ReadLine());

        string result;

        if (points == 3)
        {
            result = "выигрыш";
        }
        else if (points == 1)
        {
            result = "ничья";
        }
        else if (points == 0)
        {
            result = "проигрыш";
        }
        else
        {
            result = "неверное количество очков";
        }

        Console.WriteLine($"Результат игры - {result}");
    }
}