using System;
class program
{
    static void Main()
    {
        Console.Write("Введите количество школьников: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество яблок: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int applesPerShkolnik = k / n;
        int rApples = k % n;

        Console.WriteLine($"Каждому школьнику достанется: {applesPerShkolnik} яблок");
        Console.WriteLine($"В корзинке останется: {rApples} яблок");
    }
}