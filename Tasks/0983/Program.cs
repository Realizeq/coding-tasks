using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 4)
        {
            string result = word[1].ToString() + word[3].ToString();
            Console.WriteLine($"Буквосочетание из второго и четвертого символов: {result}");
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}