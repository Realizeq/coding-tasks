using System;
class Program
{
    static void Main()
    {
        string[] gosudarstva = {"Россия", "Китай", "США", "Канада", "Бразилия",
                               "Австралия", "Индия", "Аргентина", "Казахстан", "Алжир",
                               "Мексика", "Индонезия", "Судан", "Ливия", "Иран",
                               "Монголия", "Перу", "Чад", "Нигер", "Ангола",
                               "Мали", "ЮАР", "Колумбия", "Эфиопия", "Египет",
                               "Танзания", "Нигерия", "Венесуэла"};

        float[] naselenie = {144.1f, 1402.1f, 331.0f, 38.0f, 213.0f,
                           25.7f, 1380.0f, 45.4f, 18.8f, 43.9f,
                           128.9f, 273.5f, 43.8f, 6.9f, 83.9f,
                           3.3f, 33.0f, 16.4f, 24.2f, 32.9f,
                           20.3f, 59.3f, 50.9f, 115.0f, 102.3f,
                           59.7f, 206.1f, 28.4f};

        float[] ploshad = {17100, 9597, 9834, 9985, 8516,
                          7692, 3287, 2780, 2725, 2382,
                          1964, 1905, 1886, 1760, 1648,
                          1564, 1284, 1284, 1267, 1247,
                          1240, 1221, 1142, 1104, 1002,
                          945, 924, 912};

        float minPlotnost = float.MaxValue;
        int indexMin = -1;

        for (int i = 0; i < 28; i++)
        {
            float plotnost = naselenie[i] * 1000 / ploshad[i];
            if (plotnost < minPlotnost)
            {
                minPlotnost = plotnost;
                indexMin = i;
            }
        }

        Console.WriteLine($"Государство с минимальной плотностью населения: {gosudarstva[indexMin]}");
        Console.WriteLine($"Плотность населения: {minPlotnost:F2} чел/км²");
        Console.WriteLine($"Население: {naselenie[indexMin]} млн");
        Console.WriteLine($"Площадь: {ploshad[indexMin]} тыс. км²");
    }
}