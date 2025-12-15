using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое предложение: ");
        string predlozhenie1 = Console.ReadLine();

        Console.Write("Введите второе предложение: ");
        string predlozhenie2 = Console.ReadLine();

        string allText = predlozhenie1 + " " + predlozhenie2;
        string[] allWords = allText.Split(' ');

        Console.Write("Слова, встречающиеся в двух предложениях только один раз: ");

        for (int i = 0; i < allWords.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < allWords.Length; j++)
            {
                if (allWords[i] == allWords[j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.Write(allWords[i] + " ");
            }
        }
    }
}