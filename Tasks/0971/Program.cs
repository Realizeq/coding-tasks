using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название первой страны: ");
        string s1 = Console.ReadLine();

        Console.Write("Введите название второй страны: ");
        string s2 = Console.ReadLine();

        string t1 = s2;
        string t2 = s1;

        Console.WriteLine($"s1 = {s1}");
        Console.WriteLine($"s2 = {s2}");
        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");
    }
}