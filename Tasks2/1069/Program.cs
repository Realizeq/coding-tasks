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
                (predlozhenie[i] == 'д' || predlozhenie[i] == 'Д') &&
                (predlozhenie[i + 1] == 'а' || predlozhenie[i + 1] == 'А'))
            {
                result += predlozhenie[i] == 'д' ? 'н' : 'Н';
                result += predlozhenie[i] == 'д' ? 'е' : 'Е';
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