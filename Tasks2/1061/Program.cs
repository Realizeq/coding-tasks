using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int nPosition = -1;
        int kPosition = -1;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if ((predlozhenie[i] == 'н' || predlozhenie[i] == 'Н') && nPosition == -1)
            {
                nPosition = i;
            }
            if ((predlozhenie[i] == 'к' || predlozhenie[i] == 'К') && kPosition == -1)
            {
                kPosition = i;
            }
        }

        if (nPosition != -1 && kPosition != -1)
        {
            if (nPosition < kPosition)
            {
                Console.WriteLine($"Буква 'н' встречается раньше (позиция {nPosition + 1})");
            }
            else
            {
                Console.WriteLine($"Буква 'к' встречается раньше (позиция {kPosition + 1})");
            }
        }
        else
        {
            Console.WriteLine("Не найдены обе буквы");
        }
    }
}