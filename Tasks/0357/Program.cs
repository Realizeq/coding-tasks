using System;
class Program
{
    static void Main()
    {
        int number;
        do
        {
            Console.Write("Введите четное число: ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine("Ошибка число нечетное");
            }
        } while (number % 2 != 0);

        Console.WriteLine("Кайфи");
    }
}