using System;
class Program
{
    static void Main()
    {
        int max_len = 1;
        int current_len = 1;
        int direction = 0; // 0 - не определен, 1 - возрастает, -1 - убывает

        Console.Write("количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());

        for (int j = 2; j <= n; j++)
        {
            int current = int.Parse(Console.ReadLine());

            if (direction == 0)
            {
                if (current > prev) direction = 1;
                else if (current < prev) direction = -1;
                current_len++;
            }
            else if ((direction == 1 && current > prev) || (direction == -1 && current < prev))
            {
                current_len++;
            }
            else
            {
                if (current_len > max_len) max_len = current_len;
                current_len = 2;
                direction = (current > prev) ? 1 : -1;
            }

            prev = current;
        }

        if (current_len > max_len) max_len = current_len;

        Console.WriteLine($"наибольшая длина монотонного фрагмента: {max_len}");
    }
}