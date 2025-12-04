using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.Write("Буквы 'и': ");
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'и' || predlozhenie[i] == 'И')
            {
                Console.Write(predlozhenie[i] + " ");
            }
        }
    }
}