using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 5)
        {
            char[] chars = word.ToCharArray();

            char temp = chars[1];
            chars[1] = chars[4];
            chars[4] = temp;

            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово должно содержать не менее 5 букв");
        }
    }
}