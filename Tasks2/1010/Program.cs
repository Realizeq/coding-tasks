using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите символ: ");
        char simvol = Console.ReadLine()[0];

        Console.Write("Введите количество: ");
        int kolichestvo = int.Parse(Console.ReadLine());

        string result = new string(simvol, kolichestvo);
        Console.WriteLine(result);
    }
}