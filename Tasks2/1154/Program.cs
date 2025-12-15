using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.Write("Различные слова: ");

        for (int i = 0; i < words.Length; i++)
        {
            bool alreadyPrinted = false;

            for (int j = 0; j < i; j++)
            {
                if (words[i] == words[j])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (!alreadyPrinted)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}