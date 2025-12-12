using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string result = "";

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (i < predlozhenie.Length - 1 &&
                (predlozhenie[i] == 'а' || predlozhenie[i] == 'А') &&
                (predlozhenie[i + 1] == 'х' || predlozhenie[i + 1] == 'Х'))
            {
                result += predlozhenie[i] == 'а' ? 'у' : 'У';
                result += predlozhenie[i + 1];
                i++;
            }
            else
            {
                result += predlozhenie[i];
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}