using System;
class program
{
    static void Main()
    {
        int yarusov = 10;
        int sekciy = 8;

        Console.Write("Введите номер места: ");
        int mesto = int.Parse(Console.ReadLine());

        int sekciya = (mesto - 1) % sekciy + 1;
        int yarus = (mesto - 1) / sekciy + 1;

        Console.WriteLine("Секция: " + sekciya);
        Console.WriteLine("Ярус: " + yarus);
    }
}