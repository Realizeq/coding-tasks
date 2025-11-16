using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) Один вопрос:");
        int a1 = rand.Next(1, 10);
        int b1 = rand.Next(1, 10);
        Console.Write($"Чему равно произведение {a1}×{b1}? ");
        int otvet1 = int.Parse(Console.ReadLine());
        if (otvet1 == a1 * b1)
        {
            Console.WriteLine("Правильно!");
        }
        else
        {
            Console.WriteLine($"Неправильно! Правильный ответ: {a1 * b1}");
        }

        Console.WriteLine("б) 20 вопросов:");
        int pravilno = 0;
        int nepravilno = 0;
        for (int i = 0; i < 20; i++)
        {
            int a2 = rand.Next(1, 10);
            int b2 = rand.Next(1, 10);
            Console.Write($"Чему равно произведение {a2}×{b2}? ");
            int otvet2 = int.Parse(Console.ReadLine());
            if (otvet2 == a2 * b2)
            {
                pravilno++;
            }
            else
            {
                nepravilno++;
            }
        }
        Console.WriteLine($"Правильных: {pravilno}");
        Console.WriteLine($"Неправильных: {nepravilno}");

        Console.WriteLine("в) До ввода 0:");
        while (true)
        {
            int a3 = rand.Next(1, 10);
            int b3 = rand.Next(1, 10);
            Console.Write($"Чему равно произведение {a3}×{b3}? ");
            int otvet3 = int.Parse(Console.ReadLine());
            if (otvet3 == 0)
            {
                break;
            }
            if (otvet3 == a3 * b3)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine($"{a3 * b3}");
            }
        }
    }
}