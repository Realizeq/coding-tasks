using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int product = m * n;
        int number = 1;

        while (number <= product)
        {
            if (number % m == 0 || number % n == 0)
            {
                Console.Write($"{number} ");
            }
            number++;
        }
    }
}