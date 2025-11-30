using System;
class Program
{
    static void Main()
    {
        int[] zabito = { 85, 92, 78, 101, 88, 95, 82, 96, 89, 84, 91, 87, 99, 83, 90 };
        int[] propusheno = { 78, 89, 85, 95, 92, 88, 79, 91, 86, 90, 84, 89, 92, 81, 87 };

        for (int i = 0; i < 15; i++)
        {
            if (zabito[i] > propusheno[i])
            {
                Console.WriteLine($"Игра {i + 1}: выигрыш {zabito[i]}-{propusheno[i]}");
            }
            else
            {
                Console.WriteLine($"Игра {i + 1}: проигрыш {zabito[i]}-{propusheno[i]}");
            }
        }

        string[] result = new string[15];

        for (int i = 0; i < 15; i++)
        {
            if (zabito[i] > propusheno[i])
            {
                result[i] = "выигрыш";
            }
            else
            {
                result[i] = "проигрыш";
            }
            Console.WriteLine($"Игра {i + 1} (способ 2): {result[i]} {zabito[i]}-{propusheno[i]}");
        }
    }
}