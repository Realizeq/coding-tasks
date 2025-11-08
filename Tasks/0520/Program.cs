using System;
class Program
{
    static void Main()
    {
        bool est_dvoyki = false;

        for (int i = 1; i <= 28; i++)
        {
            Console.Write($"ученик {i}: ");
            int ocenka = int.Parse(Console.ReadLine());

            if (ocenka == 2) est_dvoyki = true;
        }

        if (est_dvoyki) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}