using System;
class Program
{
    static void Main()
    {
        string[] modeli = {"Toyota Camry", "Honda Civic", "BMW M5", "Mercedes E-Class", "Audi A6",
                          "Lexus LS", "Volkswagen Passat", "Ford Mustang", "Chevrolet Camaro", "Porsche 911",
                          "Ferrari 488", "Lamborghini Huracan", "Mazda 6", "Nissan GT-R", "Tesla Model S",
                          "Hyundai Sonata", "Kia Optima", "Subaru Impreza", "Volvo S90", "Skoda Superb"};

        int[] skorosti = {210, 200, 250, 240, 230,
                        250, 220, 250, 250, 320,
                        330, 325, 220, 315, 250,
                        210, 210, 220, 230, 220};

        Console.WriteLine("Модели со скоростью выше 180 км/ч:");
        for (int i = 0; i < 20; i++)
        {
            if (skorosti[i] > 180)
            {
                Console.WriteLine($"{modeli[i]} - {skorosti[i]} км/ч");
            }
        }
    }
}