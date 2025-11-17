using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 23, 30, 45, 50, 67, 70, 89, 90, 103 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Элементы, кратные 10, заменены нулем:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 10 == 0)
            {
                massiv[i] = 0;
            }
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Нечетные удвоены, четные уменьшены вдвое:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                massiv[i] /= 2;
            }
            else
            {
                massiv[i] *= 2;
            }
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Изменение элементов:");
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 != 0)
            {
                massiv[i] -= m;
            }
            if (i % 2 != 0)
            {
                massiv[i] += n;
            }
            Console.WriteLine($"{massiv[i]}");
        }
    }
}