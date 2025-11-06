using System;
class Program
{
    static void Main()
    {
        int count1 = 0;
        int count2 = 0;
        int time1 = 0;
        int time2 = 0;

        int i = 1;
        while (true)
        {
            Console.Write($"удаление {i} - команда (0 для окончания): ");
            int team = int.Parse(Console.ReadLine());
            if (team == 0) break;

            Console.Write($"удаление {i} - время: ");
            int time = int.Parse(Console.ReadLine());

            if (team == 1)
            {
                count1++;
                time1 += time;
            }
            else
            {
                count2++;
                time2 += time;
            }
            i++;
        }

        Console.WriteLine($"команда 1 - удалений: {count1}, время: {time1}");
        Console.WriteLine($"команда 2 - удалений: {count2}, время: {time2}");
    }
}