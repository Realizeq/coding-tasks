using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        string result = "";

        for (int i = 0; i < stroka.Length; i++)
        {
            if (stroka[i] != ' ')
            {
                result += stroka[i];
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}