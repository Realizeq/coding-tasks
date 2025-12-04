using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        int dlina = word.Length;
        string zvezdy = new string('*', dlina);
        string result = zvezdy + word + zvezdy;

        Console.WriteLine(result);
    }
}