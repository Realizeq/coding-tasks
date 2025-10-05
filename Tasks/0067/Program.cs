using System;
class program
{
    static void Main()
    {
        int totalFloors = 5;
        int totalApartments = 20;
        int apartmentsPerFloor = totalApartments / totalFloors;

        Console.Write("Введите номер квартиры (1-20): ");
        int apartmentNumber = int.Parse(Console.ReadLine());

        //Определение этажа
        int floor = (apartmentNumber - 1) / apartmentsPerFloor + 1;

        //Определение позиции на этаже
        int positionOnFloor = (apartmentNumber - 1) % apartmentsPerFloor + 1;

        Console.WriteLine($"Квартира #{apartmentNumber} находится на {floor} этаже, {positionOnFloor}-я по счету на этаже");
    }
}