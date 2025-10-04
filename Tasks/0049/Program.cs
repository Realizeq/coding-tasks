using System;
class program
{
    static void Main()
    {
        Console.Write("Введите стоимость монитора: ");
        float monitorPrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите стоимость системного блока: ");
        float systemBlockPrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите стоимость клавиатуры: ");
        float keyboardPrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите стоимость мыши: ");
        float mousePrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите количество компьютеров: ");
        int computersCount = Convert.ToInt32(Console.ReadLine());

        float oneComputerPrice = monitorPrice + systemBlockPrice + keyboardPrice + mousePrice;
        float totalPrice = oneComputerPrice * computersCount;

        Console.WriteLine($"Стоимость {computersCount} компьютеров: {totalPrice:F2} руб.");
    }
}