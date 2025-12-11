using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        bool hasComma = false;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == ',')
            {
                hasComma = true;
                break;
            }
        }

        if (hasComma)
        {
            Console.WriteLine("В предложении есть запятые");
        }
        else
        {
            Console.WriteLine("В предложении нет запятых");
        }
    }
}