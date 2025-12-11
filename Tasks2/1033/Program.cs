using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int glasnye = 0;
        string glasnyeBukvy = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (glasnyeBukvy.Contains(predlozhenie[i]))
            {
                glasnye++;
            }
        }

        Console.WriteLine($"Количество гласных букв: {glasnye}");
    }
}