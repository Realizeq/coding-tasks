using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер масти (1-4): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите номер достоинства (6-14): ");
        int k = int.Parse(Console.ReadLine());

        string suit;
        string rank;

        switch (m)
        {
            case 1:
                suit = "пик";
                break;
            case 2:
                suit = "треф";
                break;
            case 3:
                suit = "бубен";
                break;
            case 4:
                suit = "червей";
                break;
            default:
                suit = "неверная масть";
                break;
        }

        switch (k)
        {
            case 6:
                rank = "Шестерка";
                break;
            case 7:
                rank = "Семерка";
                break;
            case 8:
                rank = "Восьмерка";
                break;
            case 9:
                rank = "Девятка";
                break;
            case 10:
                rank = "Десятка";
                break;
            case 11:
                rank = "Валет";
                break;
            case 12:
                rank = "Дама";
                break;
            case 13:
                rank = "Король";
                break;
            case 14:
                rank = "Туз";
                break;
            default:
                rank = "неверное достоинство (ваше).";
                break;
        }

        Console.WriteLine($"{rank} {suit}");
    }
}