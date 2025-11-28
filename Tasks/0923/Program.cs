using System;
class Program
{
    static void Main()
    {
        int[] ochki = { 56, 52, 49, 47, 45, 43, 41, 39, 38, 36 };

        Console.WriteLine("Очки команд:");
        for (int i = 0; i < ochki.Length; i++)
        {
            Console.WriteLine($"{ochki[i]}");
        }

        bool uporyadocheno = true;
        for (int i = 0; i < ochki.Length - 1; i++)
        {
            if (ochki[i] < ochki[i + 1])
            {
                uporyadocheno = false;
                break;
            }
        }

        if (uporyadocheno)
        {
            Console.WriteLine("Команды перечислены по занятым местам");
        }
        else
        {
            Console.WriteLine("Команды не перечислены по занятым местам");
        }
    }
}