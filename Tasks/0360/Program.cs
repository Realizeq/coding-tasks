using System;
class Program
{
    static void Main()
    {
        int number;

        do
        {
            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели - {number}");
        } while (number != 0);

        Console.WriteLine("Конец");
    }
}