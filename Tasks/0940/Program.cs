using System;
class Program
{
    static void Main()
    {
        int[] zabito = { 2, 1, 3, 0, 2, 1, 1, 2, 0, 3, 1, 2, 0, 1, 2, 1, 0, 2, 1, 1 };
        int[] propusheno = { 1, 1, 2, 2, 1, 0, 2, 2, 0, 2, 1, 1, 1, 0, 1, 2, 1, 1, 0, 2 };

        for (int i = 0; i < 20; i++)
        {
            if (zabito[i] > propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: выигрыш {zabito[i]}-{propusheno[i]}");
            }
            else if (zabito[i] < propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: проигрыш {zabito[i]}-{propusheno[i]}");
            }
            else
            {
                Console.WriteLine($"Игра {i + 1}: ничья {zabito[i]}-{propusheno[i]}");
            }
        }

        string[] result = new string[20];

        for (int i = 0; i < 20; i++)
        {
            if (zabito[i] > propusheno[i])
            {
                result[i] = "выигрыш";
            }
            else if (zabito[i] < propusheno[i])
            {
                result[i] = "проигрыш";
            }
            else
            {
                result[i] = "ничья";
            }
            Console.WriteLine($"Игра {i + 1} (способ 2): {result[i]} {zabito[i]}-{propusheno[i]}");
        }
    }
}