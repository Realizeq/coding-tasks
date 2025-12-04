using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово из 12 букв: ");
        string word = Console.ReadLine();

        if (word.Length == 12)
        {
            string tret1 = word.Substring(0, 4);
            string tret2 = word.Substring(4, 4);
            string tret3 = word.Substring(8, 4);

            string resultA = tret2 + tret3 + tret1;
            string resultB = tret3 + tret1 + tret2;

            Console.WriteLine($"Исходное слово: {word}");
            Console.WriteLine($"Вариант а: {resultA}");
            Console.WriteLine($"Вариант б: {resultB}");
        }
        else
        {
            Console.WriteLine("Слово должно содержать 12 букв");
        }
    }
}