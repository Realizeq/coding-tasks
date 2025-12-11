using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.WriteLine("Первые 6 слов:");
        for (int i = 0; i < 6 && i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}