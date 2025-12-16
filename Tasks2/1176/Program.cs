using System;
class Program
{
    static void Main()
    {
        string[] tovary = {"Хлеб", "Молоко", "Сахар", "Масло", "Яйца",
                          "Мясо", "Рыба", "Сыр", "Колбаса", "Чай",
                          "Кофе", "Конфеты", "Печенье", "Шоколад", "Сок",
                          "Вода", "Овощи", "Фрукты", "Макароны", "Рис"};

        int[] rubli = {50, 80, 60, 120, 90,
                      350, 200, 250, 300, 100,
                      400, 200, 80, 120, 150,
                      40, 100, 150, 60, 70};

        int[] kopeyki = {50, 0, 0, 0, 0,
                        0, 0, 0, 0, 0,
                        0, 0, 0, 0, 0,
                        0, 0, 0, 0, 0};

        Console.Write("Введите номер первого товара (1-20): ");
        int n1 = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Введите номер второго товара (1-20): ");
        int n2 = int.Parse(Console.ReadLine()) - 1;

        if (n1 < 0 || n1 >= 20 || n2 < 0 || n2 >= 20)
        {
            Console.WriteLine("Некорректные номера товаров");
            return;
        }

        int price1 = rubli[n1] * 100 + kopeyki[n1];
        int price2 = rubli[n2] * 100 + kopeyki[n2];

        Console.WriteLine($"Товар 1: {tovary[n1]} - {rubli[n1]},{kopeyki[n1]:D2} руб");
        Console.WriteLine($"Товар 2: {tovary[n2]} - {rubli[n2]},{kopeyki[n2]:D2} руб");

        if (price1 > price2)
        {
            Console.WriteLine($"Товар '{tovary[n1]}' дороже");
        }
        else if (price2 > price1)
        {
            Console.WriteLine($"Товар '{tovary[n2]}' дороже");
        }
        else
        {
            Console.WriteLine("Товары стоят одинаково");
        }
    }
}