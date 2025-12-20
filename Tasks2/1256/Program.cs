using System;
class Program
{
    static int PosledniyIndex(string predlozhenie, char bukva)
    {
        int posledniy = -1;
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == bukva || predlozhenie[i] == char.ToUpper(bukva))
                posledniy = i;
        }
        return posledniy;
    }

    static void Main()
    {
        Console.Write("Введите первое предложение: ");
        string pred1 = Console.ReadLine();
        Console.Write("Введите второе предложение: ");
        string pred2 = Console.ReadLine();

        int nomer1 = PosledniyIndex(pred1, 'й');
        int nomer2 = PosledniyIndex(pred2, 'й');

        if (nomer1 == -1 && nomer2 == -1)
            Console.WriteLine("Буква 'й' не найдена в обоих предложениях");
        else if (nomer1 == -1)
            Console.WriteLine($"Буква 'й' найдена только во втором предложении (номер {nomer2 + 1})");
        else if (nomer2 == -1)
            Console.WriteLine($"Буква 'й' найдена только в первом предложении (номер {nomer1 + 1})");
        else if (nomer1 > nomer2)
            Console.WriteLine($"В первом предложении номер последней 'й' больше ({nomer1 + 1} > {nomer2 + 1})");
        else if (nomer2 > nomer1)
            Console.WriteLine($"Во втором предложении номер последней 'й' больше ({nomer2 + 1} > {nomer1 + 1})");
        else
            Console.WriteLine($"Номера последних букв 'й' одинаковы ({nomer1 + 1})");
    }
}