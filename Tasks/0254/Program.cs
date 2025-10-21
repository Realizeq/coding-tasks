using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите год нашей эры: ");
        int n = int.Parse(Console.ReadLine());

        // старт цикла с крысы
        int startYear = 1984;

        // цикл 60 лет
        int position = (n - startYear) % 60;
        if (position < 0) position += 60;

        // цикл 12 лет (животное)
        string[] animals = {
            "Крыса", "Корова", "Тигр", "Заяц", "Дракон", "Змея",
            "Лошадь", "Овца", "Обезьяна", "Петух", "Собака", "Свинья"
        };
        int animalIndex = position % 12;
        string animal = animals[animalIndex];

        // цикл 5 лет (цвет по 2 года каждый)
        string[] colors = {
            "Зеленый", "Зеленый",
            "Красный", "Красный",
            "Желтый", "Желтый",
            "Белый", "Белый",
            "Черный", "Черный"
        };
        int colorIndex = (position % 10);
        string color = colors[colorIndex];

        Console.WriteLine($"{color} {animal}");
    }
}