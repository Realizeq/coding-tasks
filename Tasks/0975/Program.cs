using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название первого города: ");
        string gorod1 = Console.ReadLine();

        Console.Write("Введите название второго города: ");
        string gorod2 = Console.ReadLine();

        Console.Write("Введите название третьего города: ");
        string gorod3 = Console.ReadLine();

        string samoeDlinnoye = gorod1;
        string samoeKorotkoye = gorod1;

        if (gorod2.Length > samoeDlinnoye.Length)
        {
            samoeDlinnoye = gorod2;
        }
        if (gorod3.Length > samoeDlinnoye.Length)
        {
            samoeDlinnoye = gorod3;
        }

        if (gorod2.Length < samoeKorotkoye.Length)
        {
            samoeKorotkoye = gorod2;
        }
        if (gorod3.Length < samoeKorotkoye.Length)
        {
            samoeKorotkoye = gorod3;
        }

        Console.WriteLine($"Самое длинное название: {samoeDlinnoye}");
        Console.WriteLine($"Самое короткое название: {samoeKorotkoye}");
    }
}