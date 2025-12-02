using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первую фамилию: ");
        string fam1 = Console.ReadLine();

        Console.Write("Введите вторую фамилию: ");
        string fam2 = Console.ReadLine();

        int dlina1 = fam1.Length;
        int dlina2 = fam2.Length;

        if (dlina1 > dlina2)
        {
            Console.WriteLine($"Первая фамилия длиннее: {dlina1} символов");
        }
        else if (dlina2 > dlina1)
        {
            Console.WriteLine($"Вторая фамилия длиннее: {dlina2} символов");
        }
        else
        {
            Console.WriteLine($"Фамилии одинаковой длины: {dlina1} символов");
        }
    }
}