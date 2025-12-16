using System;
class Program
{
    static void Main()
    {
        string[] materiały = {"Алюминий", "Сталь", "Медь", "Свинец", "Золото",
                             "Серебро", "Титан", "Олово", "Цинк", "Никель",
                             "Железо", "Платина", "Вольфрам", "Серебро", "Бронза",
                             "Латунь", "Чугун", "Магний", "Калий", "Натрий",
                             "Литий", "Кальций", "Барий", "Стронций", "Цирконий",
                             "Хром", "Марганец", "Кобальт", "Молибден", "Ванадий"};

        float[] massa = {2.7f, 7.8f, 8.9f, 11.3f, 19.3f,
                        10.5f, 4.5f, 7.3f, 7.1f, 8.9f,
                        7.9f, 21.5f, 19.3f, 10.5f, 8.7f,
                        8.4f, 7.2f, 1.7f, 0.86f, 0.97f,
                        0.53f, 1.55f, 3.5f, 2.6f, 6.5f,
                        7.2f, 7.4f, 8.9f, 10.2f, 6.1f};

        float[] obem = {1, 1, 1, 1, 1,
                       1, 1, 1, 1, 1,
                       1, 1, 1, 1, 1,
                       1, 1, 1, 1, 1,
                       1, 1, 1, 1, 1,
                       1, 1, 1, 1, 1};

        float minPlotnost = float.MaxValue;
        int indexMin = -1;

        for (int i = 0; i < 30; i++)
        {
            float plotnost = massa[i] * 1000 / obem[i];
            if (plotnost < minPlotnost)
            {
                minPlotnost = plotnost;
                indexMin = i;
            }
        }

        Console.WriteLine($"Минимальная плотность: {minPlotnost:F2} г/см³");
        Console.WriteLine($"Материал: {materiały[indexMin]}");
        Console.WriteLine($"Масса: {massa[indexMin]} кг");
    }
}