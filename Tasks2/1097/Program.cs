using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение, оканчивающееся на '_': ");
        string predlozhenie = Console.ReadLine();

        Console.Write("Введите букву для вставки: ");
        char letter = Console.ReadLine()[0];

        string result = "";
        int lastI = -1;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'и' || predlozhenie[i] == 'И')
            {
                lastI = i;
            }
        }

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (i == lastI)
            {
                result += letter;
            }
            result += predlozhenie[i];
        }

        Console.WriteLine($"Результат: {result}");
    }
}