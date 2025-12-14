using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        int minLength = int.MaxValue;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < minLength)
            {
                minLength = words[i].Length;
            }
        }

        Console.WriteLine($"Длина самого короткого слова: {minLength}");
    }
}