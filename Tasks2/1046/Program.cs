using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите полное имя файла: ");
        string fileName = Console.ReadLine();

        string[] parts = fileName.Split('\\');

        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}