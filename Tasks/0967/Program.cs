using System;
class Program
{
    static void Main()
    {
        string[] slova = { "кот", "собака", "птица", "крокодил", "медведь", "кит", "конь", "олень", "корова", "кошка" };

        float summDlin = 0;
        int bolshe5 = 0;
        int maxDlina = 0;
        int minIndex = 0;
        int minDlina = int.MaxValue;
        int predMax = 0;
        int kSlov = 0;

        for (int i = 0; i < 10; i++)
        {
            int dlina = slova[i].Length;
            summDlin += dlina;

            if (dlina > 5)
            {
                bolshe5++;
            }

            if (dlina > maxDlina)
            {
                maxDlina = dlina;
            }

            if (dlina < minDlina)
            {
                minDlina = dlina;
                minIndex = i;
            }

            if (slova[i][0] == 'к' || slova[i][0] == 'К')
            {
                kSlov++;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            int dlina = slova[i].Length;
            if (dlina < maxDlina && dlina > predMax)
            {
                predMax = dlina;
            }
        }

        float sredDlina = summDlin / 10;

        Console.WriteLine($"Средняя длина слова: {sredDlina}");
        Console.WriteLine($"Слов с длиной >5: {bolshe5}");
        Console.WriteLine($"Символов в самом длинном слове: {maxDlina}");
        Console.WriteLine($"Номер первого самого короткого слова: {minIndex + 1}");
        Console.WriteLine($"Символов в предмаксимальном слове: {predMax}");
        Console.WriteLine($"Слов на 'к': {kSlov}");

        string[] sortSlova = new string[10];
        Array.Copy(slova, sortSlova, 10);
        Array.Sort(sortSlova);

        Console.Write("Слова по алфавиту: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(sortSlova[i] + " ");
        }
    }
}