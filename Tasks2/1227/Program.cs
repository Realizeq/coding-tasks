using System;
class Program
{
    static void TrapeziaInfo(double osnovanie1, double osnovanie2, double vysota, out double perimeter, out double area)
    {
        area = (osnovanie1 + osnovanie2) * vysota / 2;

        double raznost = Math.Abs(osnovanie1 - osnovanie2) / 2;
        double bokovayaStorona = Math.Sqrt(raznost * raznost + vysota * vysota);

        perimeter = osnovanie1 + osnovanie2 + 2 * bokovayaStorona;
    }

    static void Main()
    {
        Console.Write("Введите первое основание, второе основание и высоту первой трапеции: ");
        string[] input1 = Console.ReadLine().Split(' ');
        double osn11 = double.Parse(input1[0]);
        double osn12 = double.Parse(input1[1]);
        double vys1 = double.Parse(input1[2]);

        Console.Write("Введите первое основание, второе основание и высоту второй трапеции: ");
        string[] input2 = Console.ReadLine().Split(' ');
        double osn21 = double.Parse(input2[0]);
        double osn22 = double.Parse(input2[1]);
        double vys2 = double.Parse(input2[2]);

        double per1, area1;
        double per2, area2;

        TrapeziaInfo(osn11, osn12, vys1, out per1, out area1);
        TrapeziaInfo(osn21, osn22, vys2, out per2, out area2);

        double sumPer = per1 + per2;
        double sumArea = area1 + area2;

        Console.WriteLine($"\nПервая трапеция: периметр = {per1:F2}, площадь = {area1:F2}");
        Console.WriteLine($"Вторая трапеция: периметр = {per2:F2}, площадь = {area2:F2}");
        Console.WriteLine($"Сумма периметров: {sumPer:F2}");
        Console.WriteLine($"Сумма площадей: {sumArea:F2}");
    }
}