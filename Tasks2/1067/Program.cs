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
            if ((i + 1) % 3 == 0)
            {
                result += 'а';
            }
            else
            {
                result += predlozhenie[i];
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}