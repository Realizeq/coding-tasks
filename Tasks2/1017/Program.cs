using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.Write("Буквы 'м' и 'н': ");
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'м' || predlozhenie[i] == 'М' ||
                predlozhenie[i] == 'н' || predlozhenie[i] == 'Н')
            {
                Console.Write(predlozhenie[i] + " ");
            }
        }
    }
}