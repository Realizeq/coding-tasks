using System;
class program
{
    static void Main()
    {
        Console.Write("Введите возраст Тани: ");
        float tanyaAge = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите возраст Мити: ");
        float mityaAge = Convert.ToSingle(Console.ReadLine());

        float averageAge = (tanyaAge + mityaAge) / 2f;
        float tanyaDiff = tanyaAge - averageAge;
        float mityaDiff = mityaAge - averageAge;

        Console.WriteLine($"Средний возраст: {averageAge} лет");
        Console.WriteLine($"Возраст Тани отличается на: {tanyaDiff} лет");
        Console.WriteLine($"Возраст Мити отличается на: {mityaDiff} лет");
    }
}