using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите возраст Мити: ");
        int mitya = int.Parse(Console.ReadLine());

        Console.Write("Введите возраст Васи: ");
        int vasya = int.Parse(Console.ReadLine());

        string result;

        if (mitya > vasya)
        {
            result = "Митя старше";
        }
        else if (mitya < vasya)
        {
            result = "Вася старше";
        }
        else
        {
            result = "Одного возраста";
        }

        Console.WriteLine(result);
    }
}