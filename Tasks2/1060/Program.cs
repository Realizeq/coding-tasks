using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int firstComma = -1;
        int secondComma = -1;
        int commaCount = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == ',')
            {
                commaCount++;
                if (commaCount == 1)
                {
                    firstComma = i;
                }
                else if (commaCount == 2)
                {
                    secondComma = i;
                    break;
                }
            }
        }

        if (firstComma != -1)
        {
            if (secondComma != -1)
            {
                string result = predlozhenie.Substring(firstComma + 1, secondComma - firstComma - 1);
                Console.WriteLine($"Символы между первой и второй запятыми: {result}");
            }
            else
            {
                string result = predlozhenie.Substring(firstComma + 1);
                Console.WriteLine($"Символы после единственной запятой: {result}");
            }
        }
        else
        {
            Console.WriteLine("В предложении нет запятых");
        }
    }
}