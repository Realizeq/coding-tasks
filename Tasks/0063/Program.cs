using System;
class program
{
    static void Main()
    {
        Console.Write("Введите номер билета: ");
        int ticketNumber = Convert.ToInt32(Console.ReadLine());

        if (ticketNumber < 1643 || ticketNumber > 1643 + 299)
        {
            Console.WriteLine("Такого билета нет в кинотеатре");
            return;
        }

        int seatsPerRow = 15;
        int totalSeats = 300;

        int seatNumber = ticketNumber - 1643 + 1;

        int row = (seatNumber - 1) / seatsPerRow + 1;

        Console.WriteLine($"Билет #{ticketNumber} находится в ряду #{row}");
    }
}