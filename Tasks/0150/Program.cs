using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            Console.WriteLine($"Число {number} является двузначным");
        }
        else
        {
            Console.WriteLine($"Число {number} не является двузначным");
        }
    }
}