using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название первой страны: ");
        string s1 = Console.ReadLine();

        Console.Write("Введите название второй страны: ");
        string s2 = Console.ReadLine();

        Console.WriteLine($"До обмена: s1 = {s1}, s2 = {s2}");

        string temp = s1;
        s1 = s2;
        s2 = temp;

        Console.WriteLine($"После обмена: s1 = {s1}, s2 = {s2}");
    }
}