using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер карты (6-14): ");
        int k = int.Parse(Console.ReadLine());

        string card;

        switch (k)
        {
            case 6:
                card = "шестерка";
                break;
            case 7:
                card = "семерка";
                break;
            case 8:
                card = "восьмерка";
                break;
            case 9:
                card = "девятка";
                break;
            case 10:
                card = "десятка";
                break;
            case 11:
                card = "валет";
                break;
            case 12:
                card = "дама";
                break;
            case 13:
                card = "король";
                break;
            case 14:
                card = "туз";
                break;
            default:
                card = "ты не понимаешь что нет такого номера ?";
                break;
        }

        Console.WriteLine(card);
    }
}