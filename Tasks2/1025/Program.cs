using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'а' || predlozhenie[i] == 'А')
            {
                count++;
            }
        }

        if (predlozhenie.Length > 0)
        {
            float procent = (float)count / predlozhenie.Length * 100;
            Console.WriteLine($"Букв 'а': {count}, доля: {procent:F2}%");
        }
        else
        {
            Console.WriteLine("Предложение пустое");
        }
    }
}