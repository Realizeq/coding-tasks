using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        Console.Write("Введите подстроку для замены: ");
        string search = Console.ReadLine();

        Console.Write("Введите подстроку замены: ");
        string replace = Console.ReadLine();

        string result = stroka.Replace(search, replace);

        Console.WriteLine($"Результат: {result}");
    }
}