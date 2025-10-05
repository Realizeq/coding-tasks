using System;
class program
{
    static void Main()
    {
        // Для хранения переменных
        int chislo;
        int desyatki;
        int edinici;
        int summa;

        Console.Write("Введите двухзначное число: ");
        chislo = int.Parse(Console.ReadLine());

        desyatki = chislo / 10;
        edinici = chislo % 10;
        summa = desyatki + edinici;

        Console.WriteLine("Десятки: " + desyatki);
        Console.WriteLine("Единицы: " + edinici);
        Console.WriteLine("Сумма: " + summa);
    }
}