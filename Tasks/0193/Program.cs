using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите стоимость в копейках: ");
        int n = int.Parse(Console.ReadLine());

        int rubles = n / 100;
        int kopeeks = n % 100;

        string rubleWord;
        string kopekWord;

        if (rubles % 10 == 1 && rubles % 100 != 11)
        {
            rubleWord = "рубль";
        }
        else if (rubles % 10 >= 2 && rubles % 10 <= 4 && (rubles % 100 < 10 || rubles % 100 >= 20))
        {
            rubleWord = "рубля";
        }
        else
        {
            rubleWord = "рублей";
        }

        if (kopeeks % 10 == 1 && kopeeks % 100 != 11)
        {
            kopekWord = "копейка";
        }
        else if (kopeeks % 10 >= 2 && kopeeks % 10 <= 4 && (kopeeks % 100 < 10 || kopeeks % 100 >= 20))
        {
            kopekWord = "копейки";
        }
        else
        {
            kopekWord = "копеек";
        }

        if (kopeeks == 0)
        {
            Console.WriteLine($"{rubles} {rubleWord} ровно");
        }
        else
        {
            Console.WriteLine($"{rubles} {rubleWord} {kopeeks} {kopekWord}");
        }
    }
}