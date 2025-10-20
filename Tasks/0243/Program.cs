using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("январь");
                break;
            case 2:
                Console.WriteLine("февраль");
                break;
            case 3:
                Console.WriteLine("март");
                break;
            case 4:
                Console.WriteLine("апрель");
                break;
            case 5:
                Console.WriteLine("май");
                break;
            case 6:
                Console.WriteLine("июнь");
                break;
            case 7:
                Console.WriteLine("июль");
                break;
            case 8:
                Console.WriteLine("август");
                break;
            case 9:
                Console.WriteLine("сентябрь");
                break;
            case 10:
                Console.WriteLine("октябрь");
                break;
            case 11:
                Console.WriteLine("ноябрь");
                break;
            case 12:
                Console.WriteLine("декабрь");
                break;
            default:
                Console.WriteLine("неверный номер");
                break;
        }
    }
}