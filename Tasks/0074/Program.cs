using System;
class program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int tens = number / 10;
        int units = number % 10;
        int newNumber = units * 10 + tens;

        Console.WriteLine("Число: " + newNumber);
    }
}