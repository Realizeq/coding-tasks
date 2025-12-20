using System;
class Program
{
    static int DneyVMes(int m, int g)
    {
        if (m == 2)
        {
            bool visok = (g % 4 == 0 && g % 100 != 0) || (g % 400 == 0);
            return visok ? 29 : 28;
        }
        if (m == 4 || m == 6 || m == 9 || m == 11) return 30;
        return 31;
    }

    static void Main()
    {
        Console.Write("Введите год: ");
        int g = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц (1-12): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        // след день
        int ng = g, nm = m, nn = n + 1;
        if (nn > DneyVMes(m, g))
        {
            nn = 1;
            nm++;
            if (nm > 12)
            {
                nm = 1;
                ng++;
            }
        }

        // пред день
        int pg = g, pm = m, pn = n - 1;
        if (pn < 1)
        {
            pm--;
            if (pm < 1)
            {
                pm = 12;
                pg--;
            }
            pn = DneyVMes(pm, pg);
        }

        Console.WriteLine($"Следующий день: {ng}-{nm:D2}-{nn:D2}");
        Console.WriteLine($"Предыдущий день: {pg}-{pm:D2}-{pn:D2}");
    }
}