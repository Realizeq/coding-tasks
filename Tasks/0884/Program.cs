using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 54, 17, 50 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());

        int countS5 = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            int chislo = Math.Abs(massiv[i]);
            while (chislo > 0)
            {
                if (chislo % 10 == 5)
                {
                    countS5++;
                    break;
                }
                chislo /= 10;
            }
        }

        int[] noviyMassiv = new int[massiv.Length + countS5];
        int index = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            noviyMassiv[index] = massiv[i];
            index++;

            int chislo = Math.Abs(massiv[i]);
            bool est5 = false;
            while (chislo > 0)
            {
                if (chislo % 10 == 5)
                {
                    est5 = true;
                    break;
                }
                chislo /= 10;
            }

            if (est5)
            {
                noviyMassiv[index] = a;
                index++;
            }
        }

        Console.WriteLine("После вставки:");
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine($"Максимальный размер исходного массива: {massiv.Length * 2}");
    }
}