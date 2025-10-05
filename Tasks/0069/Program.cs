using System;
class program
{
    static void Main()
    {
        int floors = 9;
        int entrances = 4;
        int apartmentsPerFloor = 6;

        int apartmentsPerEntrance = floors * apartmentsPerFloor; // 54 подъезде
        int totalApartments = entrances * apartmentsPerEntrance; // 216 всего

        Console.Write($"Введите номер квартиры (1-{totalApartments}): ");
        int apartmentNumber = int.Parse(Console.ReadLine());

        // 1) Определение номера подъезда
        int entrance = (apartmentNumber - 1) / apartmentsPerEntrance + 1;

        // 2) Определение этажа в подъезде
        int floorInEntrance = ((apartmentNumber - 1) % apartmentsPerEntrance) / apartmentsPerFloor + 1;

        // 3) Определение номера на этаже
        int positionOnFloor = (apartmentNumber - 1) % apartmentsPerFloor + 1;

        Console.WriteLine($"Квартира {apartmentNumber}:");
        Console.WriteLine($"1) Находится в подъезде {entrance}");
        Console.WriteLine($"2) Находится на {floorInEntrance} этаже");
        Console.WriteLine($"3) {positionOnFloor}-й по счету на этаже");
    }
}