using System;
class Program
{
    static void Main()
    {
        float vklad = 1000.0f;
        int mesyac = 0;

        float uvelichenie;
        int mesyacA = 0;
        float tempVklad = 1000.0f;

        do
        {
            mesyacA++;
            uvelichenie = tempVklad * 0.02f;
            tempVklad += uvelichenie;
        } while (uvelichenie <= 30.0f);

        Console.WriteLine($"а) {mesyacA}");

        vklad = 1000.0f;
        int mesyacB = 0;

        while (vklad <= 1200.0f)
        {
            mesyacB++;
            vklad *= 1.02f;
        }

        Console.WriteLine($"б) {mesyacB}");
    }
}