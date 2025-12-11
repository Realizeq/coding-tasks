using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        bool found = false;
        int position = -1;

        for (int i = 0; i < predlozhenie.Length - 1; i++)
        {
            if ((predlozhenie[i] == 'ч' && predlozhenie[i + 1] == 'у') ||
                (predlozhenie[i] == 'щ' && predlozhenie[i + 1] == 'у') ||
                (predlozhenie[i] == 'Ч' && predlozhenie[i + 1] == 'у') ||
                (predlozhenie[i] == 'Щ' && predlozhenie[i + 1] == 'у') ||
                (predlozhenie[i] == 'ч' && predlozhenie[i + 1] == 'У') ||
                (predlozhenie[i] == 'щ' && predlozhenie[i + 1] == 'У'))
            {
                found = true;
                position = i + 1;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"Буквосочетание найдено, порядковый номер первой буквы: {position}");
        }
        else
        {
            Console.WriteLine("Буквосочетаний 'чу' или 'щу' нет");
        }
    }
}