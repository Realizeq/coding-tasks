using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название футбольного клуба: ");
        string club = Console.ReadLine();

        int dlina = club.Length;
        Console.WriteLine($"Количество символов в названии: {dlina}");
    }
}