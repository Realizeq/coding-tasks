using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово из 15 букв: ");
        string word = Console.ReadLine();

        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());

        if (word.Length == 15 && k > 0 && s > 0 && k < s && k < word.Length && s <= word.Length)
        {
            char[] chars = word.ToCharArray();

            for (int i = k, j = s - 2; i < j; i++, j--)
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
            Console.WriteLine("Некорректные данные");
        }
    }
}