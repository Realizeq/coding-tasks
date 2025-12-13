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
            if (stroka[i] == 'а')
            {
                result += 'б';
            }
            else if (stroka[i] == 'б')
            {
                result += 'а';
            }
            else if (stroka[i] == 'А')
            {
                result += 'Б';
            }
            else if (stroka[i] == 'Б')
            {
                result += 'А';
            }
            else
            {
                result += stroka[i];
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}