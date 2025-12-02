using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово (четное количество букв): ");
        string word = Console.ReadLine();

        if (word.Length % 2 == 0 && word.Length > 0)
        {
            string polovina = word.Substring(0, word.Length / 2);
            Console.WriteLine($"Первая половина слова: {polovina}");
        }
        else if (word.Length == 0)
        {
            Console.WriteLine("Слово пустое");
        }
        else
        {
            Console.WriteLine("Количество букв нечетное");
        }
    }
}