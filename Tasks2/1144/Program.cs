using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        if (words.Length >= 2)
        {
            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;

            Console.Write("Результат: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("В предложении должно быть минимум 2 слова");
        }
    }
}