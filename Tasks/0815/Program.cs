using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 25, 17, 30, 11, 26 };

        bool estOdinakovye = false;

        for (int i = 0; i < massiv.Length; i++)
        {
            for (int j = i + 1; j < massiv.Length; j++)
            {
                if (massiv[i] == massiv[j])
                {
                    estOdinakovye = true;
                    Console.WriteLine($"Одинаковые элементы: {massiv[i]} на позициях {i} и {j}");
                }
            }
        }

        if (!estOdinakovye)
        {
            Console.WriteLine("Одинаковых элементов нет");
        }
    }
}