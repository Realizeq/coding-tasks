using System;
class Program
{
    static void Main()
    {
        int[] cena = new int[5];
        int[] kolichestvo1 = new int[5];
        int[] kolichestvo2 = new int[5];
        int[] kolichestvo3 = new int[5];
        int[] kolichestvo4 = new int[5];
        int[] kolichestvo5 = new int[5];
        int[] kolichestvo6 = new int[5];

        Console.WriteLine("Введите стоимость каждого вида товара:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Вид товара {i + 1}: ");
            cena[i] = int.Parse(Console.ReadLine());
        }

        for (int den = 0; den < 6; den++)
        {
            Console.WriteLine($"День {den + 1}:");
            for (int tovar = 0; tovar < 5; tovar++)
            {
                Console.Write($"Количество товара {tovar + 1}: ");
                if (den == 0) kolichestvo1[tovar] = int.Parse(Console.ReadLine());
                else if (den == 1) kolichestvo2[tovar] = int.Parse(Console.ReadLine());
                else if (den == 2) kolichestvo3[tovar] = int.Parse(Console.ReadLine());
                else if (den == 3) kolichestvo4[tovar] = int.Parse(Console.ReadLine());
                else if (den == 4) kolichestvo5[tovar] = int.Parse(Console.ReadLine());
                else kolichestvo6[tovar] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Общий доход от каждого вида товара:");
        int maxDohodTovar = 0;
        int tovarMax = 1;
        for (int i = 0; i < 5; i++)
        {
            int dohod = cena[i] * (kolichestvo1[i] + kolichestvo2[i] + kolichestvo3[i] + kolichestvo4[i] + kolichestvo5[i] + kolichestvo6[i]);
            Console.WriteLine($"Товар {i + 1}: {dohod}");
            if (dohod > maxDohodTovar)
            {
                maxDohodTovar = dohod;
                tovarMax = i + 1;
            }
        }

        Console.WriteLine("Общий доход за каждый день:");
        int maxDohodDnya = 0;
        int denMax = 1;
        for (int den = 0; den < 6; den++)
        {
            int dohodDnya = 0;
            for (int tovar = 0; tovar < 5; tovar++)
            {
                int kolichestvo = 0;
                if (den == 0) kolichestvo = kolichestvo1[tovar];
                else if (den == 1) kolichestvo = kolichestvo2[tovar];
                else if (den == 2) kolichestvo = kolichestvo3[tovar];
                else if (den == 3) kolichestvo = kolichestvo4[tovar];
                else if (den == 4) kolichestvo = kolichestvo5[tovar];
                else kolichestvo = kolichestvo6[tovar];

                dohodDnya += cena[tovar] * kolichestvo;
            }
            Console.WriteLine($"День {den + 1}: {dohodDnya}");
            if (dohodDnya > maxDohodDnya)
            {
                maxDohodDnya = dohodDnya;
                denMax = den + 1;
            }
        }

        int obshiiDohod = 0;
        for (int tovar = 0; tovar < 5; tovar++)
        {
            obshiiDohod += cena[tovar] * (kolichestvo1[tovar] + kolichestvo2[tovar] + kolichestvo3[tovar] + kolichestvo4[tovar] + kolichestvo5[tovar] + kolichestvo6[tovar]);
        }
        Console.WriteLine($"Общий доход за 6 дней: {obshiiDohod}");

        Console.WriteLine($"Максимальный общий доход у товара {tovarMax}: {maxDohodTovar}");
        Console.WriteLine($"Максимальный общий доход был {denMax} дня: {maxDohodDnya}");

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        int dneiSverhA = 0;
        for (int den = 0; den < 6; den++)
        {
            int dohodDnya = 0;
            for (int tovar = 0; tovar < 5; tovar++)
            {
                int kolichestvo = 0;
                if (den == 0) kolichestvo = kolichestvo1[tovar];
                else if (den == 1) kolichestvo = kolichestvo2[tovar];
                else if (den == 2) kolichestvo = kolichestvo3[tovar];
                else if (den == 3) kolichestvo = kolichestvo4[tovar];
                else if (den == 4) kolichestvo = kolichestvo5[tovar];
                else kolichestvo = kolichestvo6[tovar];

                dohodDnya += cena[tovar] * kolichestvo;
            }
            if (dohodDnya > a) dneiSverhA++;
        }
        Console.WriteLine($"Дней с доходом больше {a}: {dneiSverhA}");
    }
}