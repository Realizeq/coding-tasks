using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 3)
        {
            char[] chars = word.ToCharArray();

            char temp = chars[2];
            chars[2] = chars[word.Length - 1];
            chars[word.Length - 1] = temp;

            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово должно содержать не менее 3 букв");
        }
    }
}