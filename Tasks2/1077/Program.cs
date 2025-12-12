using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово (четное количество букв): ");
        string word = Console.ReadLine();

        if (word.Length % 2 == 0 && word.Length > 0)
        {
            char[] chars = word.ToCharArray();

            for (int i = 0; i < word.Length; i += 2)
            {
                char temp = chars[i];
                chars[i] = chars[i + 1];
                chars[i + 1] = temp;
            }

            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово должно иметь четное количество букв");
        }
    }
}