using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите фамилию автора: ");
        string author = Console.ReadLine();

        Console.Write("Введите название романа: ");
        string roman = Console.ReadLine();

        Console.WriteLine($"Писатель {author} – автор романа {roman}");
    }
}