using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine();

        string fullName = name + " " + surname;
        Console.WriteLine($"Полное имя: {fullName}");
    }
}