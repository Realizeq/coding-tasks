using System;
class program
{
    static void Main()
    {
        int rows = 10;
        int columns = 5;

        Console.Write($"Введите порядковый номер (1-50): ");
        int n = int.Parse(Console.ReadLine());

        // Определение номера строки
        int rowNumber = (n - 1) / columns + 1;

        // Определение номера столбца
        int columnNumber = (n - 1) % columns + 1;

        Console.WriteLine($"Значение с порядковым номером {n}, находится в строке {rowNumber}, столбце {columnNumber}");
    }
}