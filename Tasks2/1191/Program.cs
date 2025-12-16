using System;
class Program
{
    static void Main()
    {
        string[] modeli = {"Toyota Camry", "Volvo FH", "Honda Civic", "Mercedes Actros", "BMW M5",
                          "Kamaz", "Audi A6", "MAN TGX", "Lexus LS", "Scania R-series",
                          "Volkswagen Passat", "Ford F-MAX", "Ford Mustang", "Iveco S-Way", "Porsche 911"};

        string[] tipy = {"легковой", "грузовой", "легковой", "грузовой", "легковой",
                        "грузовой", "легковой", "грузовой", "легковой", "грузовой",
                        "легковой", "грузовой", "легковой", "грузовой", "легковой"};

        float[] stoimosti = {500000, 3500000, 400000, 4000000, 3500000,
                           2500000, 2200000, 3800000, 3200000, 4200000,
                           800000, 3600000, 2500000, 3900000, 5500000};

        float summaLegkovyh = 0;
        int countLegkovyh = 0;

        for (int i = 0; i < 15; i++)
        {
            if (tipy[i] == "легковой")
            {
                summaLegkovyh += stoimosti[i];
                countLegkovyh++;
            }
        }

        if (countLegkovyh > 0)
        {
            float srednyaya = summaLegkovyh / countLegkovyh;
            Console.WriteLine($"Средняя стоимость легковых автомобилей: {srednyaya:F2} руб");
            Console.WriteLine($"Количество легковых автомобилей: {countLegkovyh}");
        }
        else
        {
            Console.WriteLine("Нет легковых автомобилей в списке");
        }
    }
}