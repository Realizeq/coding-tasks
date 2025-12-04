using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово (не менее 6 букв): ");
        string word = Console.ReadLine();

        if (word.Length >= 6)
        {
            string pervye3 = word.Substring(0, 3);
            string poslednie3 = word.Substring(word.Length - 3, 3);
            string seredina = word.Substring(3, word.Length - 6);
            string result = poslednie3 + seredina + pervye3;
            Console.WriteLine($"Способ 1: {result}");

            string result2 = "";
            for (int i = word.Length - 3; i < word.Length; i++)
            {
                result2 += word[i];
            }
            for (int i = 3; i < word.Length - 3; i++)
            {
                result2 += word[i];
            }
            for (int i = 0; i < 3; i++)
            {
                result2 += word[i];
            }
            Console.WriteLine($"Способ 2: {result2}");
        }
        else
        {
            Console.WriteLine("Слово должно содержать не менее 6 букв");
        }
    }
}