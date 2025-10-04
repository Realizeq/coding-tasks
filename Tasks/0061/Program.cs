using System;
class program
{
    static void Main()
    {
        Console.Write("Введите номер места: ");
        int seatNumber = Convert.ToInt32(Console.ReadLine());

        if (seatNumber < 1 || seatNumber > 36)
        {
            Console.WriteLine("Такого места нет");
            return;
        }

        int compartmentNumber = (seatNumber - 1) / 4 + 1;

        Console.WriteLine($"Место #{seatNumber} находится в купе #{compartmentNumber}");    
    }
}