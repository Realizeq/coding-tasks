using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int commaIndex = predlozhenie.IndexOf(',');

        if (commaIndex != -1)
        {
            string result = predlozhenie.Substring(0, commaIndex);
            Console.WriteLine($"Символы до первой запятой: {result}");
        }
        else
        {
            Console.WriteLine("В предложении нет запятых");
        }

        string result2 = "";
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == ',')
            {
                break;
            }
            result2 += predlozhenie[i];
        }
        Console.WriteLine($"Символы до первой запятой (способ 2): {result2}");
    }
}