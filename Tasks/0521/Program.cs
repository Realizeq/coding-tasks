using System;
class Program
{
    static void Main()
    {
        bool est_moshchnaya = false;

        for (int i = 1; i <= 30; i++)
        {
            Console.Write($"модель {i}: ");
            int moshchnost = int.Parse(Console.ReadLine());

            if (moshchnost > 200) est_moshchnaya = true;
        }

        if (est_moshchnaya) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}