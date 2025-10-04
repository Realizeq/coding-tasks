using System;

class Program
{
    static void Main()
    {
        int n = 0;

        // Ввод и проверка количества месяцев
        while (true)
        {
            Console.Write("Введите количество прошедших месяцев: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка! Введите неотрицательное целое число.");
            }
        }

        // Расчет номера месяца
        int x = (n % 12) + 1;

        Console.WriteLine($"x = {x}");

        // Вывод
        Console.Write($"Месяц этого дня ");
        switch (x)
        {
            case 1:
                Console.WriteLine("Январь");
                break;
            case 2:
                Console.WriteLine("Февраль");
                break;
            case 3:
                Console.WriteLine("Март");
                break;
            case 4:
                Console.WriteLine("Апрель");
                break;
            case 5:
                Console.WriteLine("Май");
                break;
            case 6:
                Console.WriteLine("Июнь");
                break;
            case 7:
                Console.WriteLine("Июль");
                break;
            case 8:
                Console.WriteLine("Август");
                break;
            case 9:
                Console.WriteLine("Сентябрь");
                break;
            case 10:
                Console.WriteLine("Октябрь");
                break;
            case 11:
                Console.WriteLine("Ноябрь");
                break;
            case 12:
                Console.WriteLine("Декабрь");
                break;
        }
    }
}