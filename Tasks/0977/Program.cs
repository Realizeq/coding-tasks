using System;
class Program
{
    static void Main()
    {
        string a = "Москва";
        string b = "Лондон";
        string c = "Париж";

        Console.WriteLine($"До обмена: a = {a}, b = {b}, c = {c}");

        string temp = b;
        b = c;
        c = a;
        a = temp;

        Console.WriteLine($"После обмена a: a = {a}, b = {b}, c = {c}");

        a = "Москва";
        b = "Лондон";
        c = "Париж";

        temp = b;
        b = a;
        a = c;
        c = temp;

        Console.WriteLine($"После обмена б: a = {a}, b = {b}, c = {c}");
    }
}