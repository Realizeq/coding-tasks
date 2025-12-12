using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово из 12 букв: ");
        string word = Console.ReadLine();

        if (word.Length == 12)
        {
            char[] chars = word.ToCharArray();

            for (int i = 2, j = 8; i < j; i++, j--)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово должно содержать 12 букв");
        }
    }
}