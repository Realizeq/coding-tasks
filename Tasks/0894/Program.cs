using System;
class Program
{
    static void Main()
    {
        int[] skorost = {180, 190, 200, 210, 220, 230, 240, 250, 260, 270,
                        280, 290, 300, 310, 320, 330, 340, 350, 360, 370,
                        380, 390, 400, 410, 420, 430, 440, 450, 460, 470};

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < skorost.Length; i++)
        {
            Console.WriteLine($"{skorost[i]}");
        }

        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        int elementK = skorost[k - 1];

        if (k > 1 && elementK < skorost[k - 2])
        {
            int poziciya = k - 1;
            while (poziciya > 0 && elementK < skorost[poziciya - 1])
            {
                skorost[poziciya] = skorost[poziciya - 1];
                poziciya--;
            }
            skorost[poziciya] = elementK;
        }
        else if (k < skorost.Length && elementK > skorost[k])
        {
            int poziciya = k - 1;
            while (poziciya < skorost.Length - 1 && elementK > skorost[poziciya + 1])
            {
                skorost[poziciya] = skorost[poziciya + 1];
                poziciya++;
            }
            skorost[poziciya] = elementK;
        }

        Console.WriteLine("После упорядочивания:");
        for (int i = 0; i < skorost.Length; i++)
        {
            Console.WriteLine($"{skorost[i]}");
        }
    }
}