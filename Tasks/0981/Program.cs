using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length > 0)
        {
            char perviy = word[0];
            char posledniy = word[word.Length - 1];

            if (perviy == posledniy)
            {
                Console.WriteLine("Слово начинается и заканчивается на одну букву");
            }
            else
            {
                Console.WriteLine("Слово начинается и заканчивается на разные буквы");
            }
        }
        else
        {
            Console.WriteLine("Слово пустое");
        }
    }
}