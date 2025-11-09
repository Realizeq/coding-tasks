using System;
class Program
{
    static void Main()
    {
        bool found = false;
        int index = 0;
        int count = 1;

        while (true)
        {
            Console.Write($"число {count}: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 100) break;

            if (!found && num == 666)
            {
                found = true;
                index = count;
            }

            count++;
        }

        if (found) Console.WriteLine($"да, номер первого: {index}");
        else Console.WriteLine("нет");
    }
}