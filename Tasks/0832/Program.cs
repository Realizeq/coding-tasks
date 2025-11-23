using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 450, 380, 520, 350, 480, 420, 550, 370, 510, };

        int min = stoimost[0];
        int indexFirst = 0;
        int indexLast = 0;

        for (int i = 1; i < stoimost.Length; i++)
        {
            if (stoimost[i] < min)
            {
                min = stoimost[i];
                indexFirst = i;
                indexLast = i;
            }
            else if (stoimost[i] == min)
            {
                indexLast = i;
            }
        }

        Console.WriteLine($"а) Первый самый дешевый: {indexFirst + 1}");
        Console.WriteLine($"б) Последний самый дешевый: {indexLast + 1}");
    }
}