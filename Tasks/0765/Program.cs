using System;
class Program
{
    static void Main()
    {
        int[] massa = { 85, 120, 95, 110, 130, 75, 100, 90, 115, 105, 125, 80, 140, 70, 150, 65, 135, 85, 145, 60, 155, 95, 160, 55, 165, 100, 170, 50, 175, 110 };

        Console.Write("Введите грузоподъемность автомобиля: ");
        int gruzopod = int.Parse(Console.ReadLine());

        int summa = 0;
        for (int i = 0; i < massa.Length; i++)
        {
            summa += massa[i];
        }

        if (summa <= gruzopod)
        {
            Console.WriteLine("Общая масса не превышает грузоподъемность");
        }
        else
        {
            Console.WriteLine("Общая масса превышает грузоподъемность");
        }
    }
}