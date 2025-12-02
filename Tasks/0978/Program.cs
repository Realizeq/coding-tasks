using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 3)
        {
            char tretiy = word[2];
            Console.WriteLine($"Третий символ: {tretiy}");
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}