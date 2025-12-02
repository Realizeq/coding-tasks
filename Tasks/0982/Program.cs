using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        if (word1.Length > 0 && word2.Length > 0)
        {
            char nachaloWord1 = word1[0];
            char konecWord2 = word2[word2.Length - 1];

            if (nachaloWord1 == konecWord2)
            {
                Console.WriteLine("первое слово начинается на ту же букву, на которую заканчивается второе");
            }
            else
            {
                Console.WriteLine("первое слово начинается на другую букву");
            }
        }
        else
        {
            Console.WriteLine("Одно из слов пустое");
        }
    }
}