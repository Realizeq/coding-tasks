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
            if (i < predlozhenie.Length - 2 &&
                (predlozhenie[i] == 'б' || predlozhenie[i] == 'Б') &&
                (predlozhenie[i + 1] == 'и' || predlozhenie[i + 1] == 'И') &&
                (predlozhenie[i + 2] == 'т' || predlozhenie[i + 2] == 'Т'))
            {
                result += predlozhenie[i] == 'б' ? 'р' : 'Р';
                result += predlozhenie[i] == 'б' ? 'о' : 'О';
                result += predlozhenie[i] == 'б' ? 'г' : 'Г';
                i += 2;
            }
            else
            {
                result += predlozhenie[i];
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}