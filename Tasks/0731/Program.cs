using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] otvety = new int[20];

        for (int i = 0; i < 20; i++)
        {
            int a = rand.Next(2, 10);
            int b = rand.Next(2, 10);

            Console.Write($"Чему равно произведение {a} на {b}? ");
            otvety[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ответы:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Вопрос {i + 1}: {otvety[i]}");
        }
    }
}