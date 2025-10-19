using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество квартир: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите номер первой квартиры: ");
        int a = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum = sum + a + i;
        }

        if (sum % 2 == 0)
        {
            Console.WriteLine("Сумма номеров четная");
        }
        else
        {
            Console.WriteLine("Сумма номеров нечетная");
        }
    }
}