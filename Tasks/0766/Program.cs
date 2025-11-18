using System;
class Program
{
    static void Main()
    {
        int[] balli = { 850, 920, 780, 950, 870, 910, 830, 890, 940, 860 };

        Console.Write("Введите необходимую сумму баллов: ");
        int neobhodimo = int.Parse(Console.ReadLine());

        int summa = 0;
        for (int i = 0; i < balli.Length; i++)
        {
            summa += balli[i];
        }

        if (summa > neobhodimo)
        {
            Console.WriteLine("Спортсмен вышел в следующий этап");
        }
        else
        {
            Console.WriteLine("Спортсмен не вышел в следующий этап");
        }
    }
}