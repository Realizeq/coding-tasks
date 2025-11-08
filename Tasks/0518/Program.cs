using System;
class Program
{
    static void Main()
    {
        bool net_troek = true;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"предмет {i}: ");
            int ocenka = int.Parse(Console.ReadLine());

            if (ocenka == 3) net_troek = false;
        }

        if (net_troek) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}