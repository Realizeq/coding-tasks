using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) Один раз:");
        Console.Write("Чет (2) или нечет (1)? ");
        int otvet = int.Parse(Console.ReadLine());
        int komp = rand.Next(1, 3);
        Console.WriteLine($"Компьютер выбрал: {komp}");
        if (otvet == komp)
        {
            Console.WriteLine("Угадал!");
        }
        else
        {
            Console.WriteLine("Не угадал!");
        }

        Console.WriteLine("б) n раз:");
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        int pobedi = 0;
        int porazheniya = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Чет (2) или нечет (1)? ");
            otvet = int.Parse(Console.ReadLine());
            komp = rand.Next(1, 3);
            Console.WriteLine($"Компьютер выбрал: {komp}");
            if (otvet == komp)
            {
                pobedi++;
            }
            else
            {
                porazheniya++;
            }
        }

        Console.WriteLine($"Счет {pobedi}:{porazheniya}");
        if (pobedi > porazheniya)
        {
            Console.WriteLine("в вашу пользу. Вы выиграли!");
        }
        else
        {
            Console.WriteLine("в пользу компьютера. Вы проиграли!");
        }

        Console.WriteLine("в) До команды остановки:");
        int verno = 0;
        int neverno = 0;
        string prodolzhit = "Да";

        while (prodolzhit == "Да")
        {
            Console.Write("Чет (2) или нечет (1)? ");
            otvet = int.Parse(Console.ReadLine());
            komp = rand.Next(1, 3);
            Console.WriteLine($"Компьютер выбрал: {komp}");
            if (otvet == komp)
            {
                verno++;
                Console.WriteLine("Верно!");
            }
            else
            {
                neverno++;
                Console.WriteLine("Неверно!");
            }

            Console.Write("Продолжить еще раз? (Да/Нет) ");
            prodolzhit = Console.ReadLine();
        }

        Console.WriteLine($"Верных ответов: {verno}");
        Console.WriteLine($"Неверных ответов: {neverno}");
    }
}