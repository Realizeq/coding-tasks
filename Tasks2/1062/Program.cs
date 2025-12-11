using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < stroka.Length - 1; i++)
        {
            if ((stroka[i] == 'и' || stroka[i] == 'И') && (stroka[i + 1] == 'л' || stroka[i + 1] == 'Л'))
            {
                if ((i == 0 || stroka[i - 1] == ' ' || stroka[i - 1] == ',' || stroka[i - 1] == '.' || stroka[i - 1] == '!') &&
                    (i + 2 >= stroka.Length || stroka[i + 2] == ' ' || stroka[i + 2] == ',' || stroka[i + 2] == '.' || stroka[i + 2] == '!'))
                {
                    count++;
                }
            }
        }

        Console.WriteLine($"Слово 'или' встречается {count} раз");
    }
}