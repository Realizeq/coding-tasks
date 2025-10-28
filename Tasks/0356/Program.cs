using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int number1 = 1;
        while (number1 * number1 <= n)
        {
            number1++;
        }
        Console.WriteLine($"Вариант 1: {number1}");

        int number2 = 1;
        do
        {
            number2++;
        } while (number2 * number2 <= n);
        Console.WriteLine($"Вариант 2: {number2}");
    }
}