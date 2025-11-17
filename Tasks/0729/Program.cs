using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) Числа, делящиеся на 13 или 17:");
        int[] massivA = new int[20];
        int chislo = 300;
        int countA = 0;

        while (countA < 20)
        {
            if (chislo % 13 == 0 || chislo % 17 == 0)
            {
                massivA[countA] = chislo;
                countA++;
            }
            chislo++;
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"[{i}] = {massivA[i]}");
        }

        Console.WriteLine("б) Первые 30 простых чисел:");
        int[] massivB = new int[30];
        int countB = 0;
        int n = 2;

        while (countB < 30)
        {
            bool prostoe = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prostoe = false;
                    break;
                }
            }

            if (prostoe)
            {
                massivB[countB] = n;
                countB++;
            }
            n++;
        }

        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine($"[{i}] = {massivB[i]}");
        }
    }
}