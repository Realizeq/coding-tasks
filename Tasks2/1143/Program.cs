using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.Write("Предложение в обратном порядке: ");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
    }
}