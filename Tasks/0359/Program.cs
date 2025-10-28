using System;
class Program
{
    static void Main()
    {
        int count = 0;

        while (count < 10)
        {
            Console.Write($"Введите число {count + 1}: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            count++;
        }

        Console.WriteLine("Ввод завершен");
    }
}