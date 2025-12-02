using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 4)
        {
            char vtoroy = word[1];
            char chetvertiy = word[3];

            if (vtoroy == chetvertiy)
            {
                Console.WriteLine("Второй и четвертый символы одинаковы");
            }
            else
            {
                Console.WriteLine("Второй и четвертый символы разные");
            }
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}