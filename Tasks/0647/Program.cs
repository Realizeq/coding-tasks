using System;
class Program
{
    static void Main()
    {
        int[] gruppa1 = new int[20];
        int[] gruppa2 = new int[20];
        int[] gruppa3 = new int[20];

        Console.WriteLine("Группа 1:");
        for (int student = 0; student < 20; student++)
        {
            Console.Write($"Средний балл студента {student + 1}: ");
            gruppa1[student] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Группа 2:");
        for (int student = 0; student < 20; student++)
        {
            Console.Write($"Средний балл студента {student + 1}: ");
            gruppa2[student] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Группа 3:");
        for (int student = 0; student < 20; student++)
        {
            Console.Write($"Средний балл студента {student + 1}: ");
            gruppa3[student] = int.Parse(Console.ReadLine());
        }

        int summa1 = 0;
        int summa2 = 0;
        int summa3 = 0;

        for (int i = 0; i < 20; i++)
        {
            summa1 += gruppa1[i];
            summa2 += gruppa2[i];
            summa3 += gruppa3[i];
        }

        float srednee1 = summa1 / 20.0f;
        float srednee2 = summa2 / 20.0f;
        float srednee3 = summa3 / 20.0f;

        Console.WriteLine($"Средний балл группы 1: {srednee1}");
        Console.WriteLine($"Средний балл группы 2: {srednee2}");
        Console.WriteLine($"Средний балл группы 3: {srednee3}");

        if (srednee1 > srednee2 && srednee1 > srednee3)
        {
            Console.WriteLine("Лучшая группа: 1");
        }
        else if (srednee2 > srednee1 && srednee2 > srednee3)
        {
            Console.WriteLine("Лучшая группа: 2");
        }
        else if (srednee3 > srednee1 && srednee3 > srednee2)
        {
            Console.WriteLine("Лучшая группа: 3");
        }
        else
        {
            Console.WriteLine("Несколько групп имеют одинаковый средний балл");
        }
    }
}