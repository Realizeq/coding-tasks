using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово из 12 букв: ");
        string word = Console.ReadLine();

        if (word.Length == 12)
        {
            string result = "";

            for (int i = 0; i < 6; i++)
            {
                result += word[i];
                result += word[11 - i];
            }

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово должно содержать 12 букв");
        }
    }
}