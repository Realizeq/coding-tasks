using System;
class program
{
    static void Main()
    {
        Console.Write("Введите номер квартиры: ");
        int apartmentNumber = Convert.ToInt32(Console.ReadLine());

        if (apartmentNumber < 1 || apartmentNumber > 75)
        {
            Console.WriteLine("Такой квартиры нет в доме");
            return;
        }

        int floors = 5;
        int apartmentsPerFloor = 15;

        int entrance = (apartmentNumber - 1) / (floors * apartmentsPerFloor) + 1;
        int floor = ((apartmentNumber - 1) % (floors * apartmentsPerFloor)) / apartmentsPerFloor + 1;

        Console.WriteLine($"Квартира #{apartmentNumber} находится в подъезде #{entrance} на этаже #{floor}");
    }
}