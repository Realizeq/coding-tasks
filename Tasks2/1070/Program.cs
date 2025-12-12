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
                (predlozhenie[i] == 'п' || predlozhenie[i] == 'П') &&
                (predlozhenie[i + 1] == 'р' || predlozhenie[i + 1] == 'Р') &&
                (predlozhenie[i + 2] == 'о' || predlozhenie[i + 2] == 'О'))
            {
                result += predlozhenie[i] == 'п' ? 'н' : 'Н';
                result += predlozhenie[i] == 'п' ? 'е' : 'Е';
                result += predlozhenie[i] == 'п' ? 'т' : 'Т';
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