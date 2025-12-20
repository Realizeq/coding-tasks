using System;
class Program
{
    static int KolvoN(string predlozhenie)
    {
        int schet = 0;
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'н' || predlozhenie[i] == 'Н')
                schet++;
        }
        return schet;
    }

    static void Main()
    {
        Console.Write("Введите первое предложение: ");
        string pred1 = Console.ReadLine();
        Console.Write("Введите второе предложение: ");
        string pred2 = Console.ReadLine();

        int kol1 = KolvoN(pred1);
        int kol2 = KolvoN(pred2);
        int vsego = kol1 + kol2;

        Console.WriteLine($"Общее количество букв 'н': {vsego}");
    }
}