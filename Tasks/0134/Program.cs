using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        string whichGreater;
        if (firstDigit > secondDigit)
        {
            whichGreater = "первая";
        }
        else if (secondDigit > firstDigit)
        {
            whichGreater = "вторая";
        }
        else
        {
            whichGreater = "равны";
        }

        bool digitsEqual = firstDigit == secondDigit;

        Console.WriteLine($"а) Какая цифра больше - {whichGreater}");
        Console.WriteLine($"б) Цифры одинаковые - {digitsEqual}");
    }
}