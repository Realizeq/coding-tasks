using System;
class Program
{
    static void Main()
    {
        float[] a = new float[40];
        Console.WriteLine("Введите 40 чисел по возрастанию:");

        for (int i = 0; i < 40; i++)
        {
            Console.Write($"a[{i + 1}]: ");
            a[i] = float.Parse(Console.ReadLine());
        }

        Console.Write("Введите число n: ");
        float n = float.Parse(Console.ReadLine());

        float sum = 0;
        bool mensheN = true;
        for (int i = 0; i < 40; i++)
        {
            if (mensheN && a[i] < n)
            {
                sum += a[i];
            }
            else
            {
                mensheN = false;
            }
        }

        int index1 = 0;
        int index2 = 0;
        float elem1 = 0;
        float elem2 = 0;
        bool found = false;
        for (int i = 0; i < 39; i++)
        {
            if (!found && a[i] < n && n < a[i + 1])
            {
                index1 = i;
                index2 = i + 1;
                elem1 = a[i];
                elem2 = a[i + 1];
                found = true;
            }
        }

        Console.WriteLine($"а) Сумма чисел меньших n: {sum}");
        Console.WriteLine($"б) n между элементами [{index1 + 1}] = {elem1} и [{index2 + 1}] = {elem2}");
    }
}