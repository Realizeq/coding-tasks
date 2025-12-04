using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int roCount = 0;
        for (int i = 0; i < predlozhenie.Length - 1; i++)
        {
            if ((predlozhenie[i] == 'р' || predlozhenie[i] == 'Р') &&
                (predlozhenie[i + 1] == 'о' || predlozhenie[i + 1] == 'О'))
            {
                roCount++;
            }
        }
        Console.WriteLine($"Буквосочетаний 'ро': {roCount}");

        Console.Write("Введите буквосочетание из двух букв: ");
        string bukvosochetanie = Console.ReadLine();

        if (bukvosochetanie.Length == 2)
        {
            int count = 0;
            for (int i = 0; i < predlozhenie.Length - 1; i++)
            {
                if (char.ToLower(predlozhenie[i]) == char.ToLower(bukvosochetanie[0]) &&
                    char.ToLower(predlozhenie[i + 1]) == char.ToLower(bukvosochetanie[1]))
                {
                    count++;
                }
            }
            Console.WriteLine($"Буквосочетаний '{bukvosochetanie}': {count}");
        }
        else
        {
            Console.WriteLine("Нужно ввести ровно две буквы");
        }

        Console.Write("Введите буквосочетание: ");
        string sochetanie = Console.ReadLine();

        int sochetanieCount = 0;
        for (int i = 0; i <= predlozhenie.Length - sochetanie.Length; i++)
        {
            bool sovpadaet = true;
            for (int j = 0; j < sochetanie.Length; j++)
            {
                if (char.ToLower(predlozhenie[i + j]) != char.ToLower(sochetanie[j]))
                {
                    sovpadaet = false;
                    break;
                }
            }
            if (sovpadaet)
            {
                sochetanieCount++;
            }
        }
        Console.WriteLine($"Буквосочетаний '{sochetanie}': {sochetanieCount}");
    }
}