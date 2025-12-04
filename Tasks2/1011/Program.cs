using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        string result = "++++" + word + "-----";
        Console.WriteLine(result);
    }
}