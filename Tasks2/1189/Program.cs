using System;
class Program
{
    static void Main()
    {
        string[] modeli = {"Toyota Camry", "Honda Civic", "BMW M5", "Mercedes E-Class", "Audi A6",
                          "Lexus LS", "Volkswagen Passat", "Ford Mustang", "Chevrolet Camaro", "Porsche 911",
                          "Ferrari 488", "Lamborghini Huracan", "Mazda 6", "Nissan GT-R", "Tesla Model S",
                          "Hyundai Sonata", "Kia Optima", "Subaru Impreza", "Volvo S90", "Skoda Superb"};

        float[] stoimosti = {500000, 400000, 3500000, 2800000, 2200000,
                           3200000, 800000, 2500000, 2400000, 5500000,
                           12000000, 15000000, 900000, 6500000, 3500000,
                           700000, 750000, 850000, 1800000, 950000};

        int[] vozrast = {3, 5, 8, 7, 4,
                        2, 10, 6, 9, 1,
                        3, 2, 7, 5, 4,
                        8, 6, 9, 3, 7};

        float summa = 0;
        int count = 0;

        for (int i = 0; i < 20; i++)
        {
            if (vozrast[i] > 6)
            {
                summa += stoimosti[i];
                count++;
            }
        }

        if (count > 0)
        {
            float srednyaya = summa / count;
            Console.WriteLine($"Средняя стоимость автомобилей старше 6 лет: {srednyaya:F2} руб");
            Console.WriteLine($"Количество таких автомобилей: {count}");
        }
        else
        {
            Console.WriteLine("Нет автомобилей старше 6 лет");
        }
    }
}