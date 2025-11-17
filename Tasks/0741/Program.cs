using System;
class Program
{
    static void Main()
    {
        int[] pobedi = { 5, 2, 7, 1, 4, 0, 3, 6, 2, 8, 1, 5, 0, 3, 2, 4, 1, 6, 0, 2 };

        Console.WriteLine("Номера команд с меньше 3 побед:");
        for (int i = 0; i < pobedi.Length; i++)
        {
            if (pobedi[i] < 3)
            {
                Console.WriteLine($"Команда {i + 1}: {pobedi[i]} побед");
            }
        }
    }
}