using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату рождения первого человека:");
        Console.Write("Год: ");
        int year1 = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int month1 = int.Parse(Console.ReadLine());
        Console.Write("День: ");
        int day1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите дату рождения второго человека:");
        Console.Write("Год: ");
        int year2 = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int month2 = int.Parse(Console.ReadLine());
        Console.Write("День: ");
        int day2 = int.Parse(Console.ReadLine());

        if (year1 < year2)
        {
            Console.WriteLine("Первый человек старше");
        }
        else if (year1 > year2)
        {
            Console.WriteLine("Второй человек старше");
        }
        else
        {
            if (month1 < month2)
            {
                Console.WriteLine("Первый человек старше");
            }
            else if (month1 > month2)
            {
                Console.WriteLine("Второй человек старше");
            }
            else
            {
                if (day1 < day2)
                {
                    Console.WriteLine("Первый человек старше");
                }
                else if (day1 > day2)
                {
                    Console.WriteLine("Второй человек старше");
                }
                else
                {
                    Console.WriteLine("Одного возраста");
                }
            }
        }
    }
}