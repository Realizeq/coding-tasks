using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название футбольного клуба: ");
        string club = Console.ReadLine();

        for (int i = 0; i < club.Length; i++)
        {
            Console.WriteLine(club[i]);
        }
    }
}