using System;
class Program
{
    static float DolyaLetters(string predlozhenie, char bukva)
    {
        int schet = 0;
        for (int i = 0; i < predlozhenie.Length; i++)
        {
            char simvol = predlozhenie[i];
            if (simvol == bukva || simvol == char.ToUpper(bukva))
                schet++;
        }
        if (predlozhenie.Length == 0) return 0;
        return (float)schet / predlozhenie.Length * 100;
    }

    static void Main()
    {
        Console.Write("Введите первое предложение: ");
        string pred1 = Console.ReadLine();
        Console.Write("Введите второе предложение: ");
        string pred2 = Console.ReadLine();

        float dolya1 = DolyaLetters(pred1, 'о');
        float dolya2 = DolyaLetters(pred2, 'о');

        if (dolya1 > dolya2)
            Console.WriteLine($"В первом предложении доля 'о' больше ({dolya1:F2}% > {dolya2:F2}%)");
        else if (dolya2 > dolya1)
            Console.WriteLine($"Во втором предложении доля 'о' больше ({dolya2:F2}% > {dolya1:F2}%)");
        else
            Console.WriteLine($"Доли буквы 'о' одинаковы ({dolya1:F2}%)");
    }
}