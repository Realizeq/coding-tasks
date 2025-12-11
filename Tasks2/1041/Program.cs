using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string firstWord = "";

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] != ' ')
            {
                firstWord += predlozhenie[i];
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Первое слово: {firstWord}");
    }
}