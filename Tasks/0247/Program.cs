using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер масти (1-4): ");
        int m = int.Parse(Console.ReadLine());

        string suit;

        switch (m)
        {
            case 1:
                suit = "пики";
                break;
            case 2:
                suit = "трефы";
                break;
            case 3:
                suit = "бубны";
                break;
            case 4:
                suit = "червы";
                break;
            default:
                suit = "ну нет такого номера братан";
                break;
        }

        Console.WriteLine(suit);
    }
}