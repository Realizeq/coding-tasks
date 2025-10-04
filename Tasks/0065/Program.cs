using System;

class Program
{
    static void Main()
    {
        int k = 0;
        int d = 0;

        // Ввод и проверка дня года k
        while (true)
        {
            Console.Write("Введите день года: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out k) && k >= 1 && k <= 365)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка! Введите число от 1 до 365.");
            }
        }

        // Ввод и проверка дня недели 1 января d
        while (true)
        {
            Console.Write("Введите день недели 1 января: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out d) && d >= 1 && d <= 7)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка! Введите число от 1 до 7.");
            }
        }

        // Расчет дня недели для k
        int n = (k + d - 2) % 7;

        Console.WriteLine($"n = {n}");

        // Вывод
        Console.Write($"{k} день года приходится на ");
        switch (n)
        {
            case 0:
                Console.WriteLine("Воскресенье");
                break;
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среду");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятницу");
                break;
            case 6:
                Console.WriteLine("Субботу");
                break;
        }
    }
}