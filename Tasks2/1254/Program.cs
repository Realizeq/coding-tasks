using System;
class Program
{
    static int KolvoBukv(string predlozhenie, char bukva)
    {
        int schet = 0;
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == bukva || predlozhenie[i] == char.ToUpper(bukva))
                schet++;
        }
        return schet;
    }

    static void Main()
    {
        Console.Write("Введите первую букву: ");
        char bukva = Console.ReadLine()[0];

        Console.Write("Введите первое предложение: ");
        string pred1 = Console.ReadLine();
        Console.Write("Введите второе предложение: ");
        string pred2 = Console.ReadLine();
        Console.Write("Введите третье предложение: ");
        string pred3 = Console.ReadLine();

        int vsego = KolvoBukv(pred1, bukva) + KolvoBukv(pred2, bukva) + KolvoBukv(pred3, bukva);

        Console.WriteLine($"Общее количество букв '{bukva}': {vsego}");
    }
}