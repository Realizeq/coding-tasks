using System;
class Program
{
    static void Main()
    {
        float probeg = 10.0f;
        float sumProbeg = 10.0f;
        int den = 1;

        float tempProbeg = 10.0f;
        int denA = 1;

        while (tempProbeg <= 20.0f)
        {
            denA++;
            tempProbeg *= 1.1f;
        }

        Console.WriteLine($"а) {denA}");

        probeg = 10.0f;
        sumProbeg = 10.0f;
        int denB = 1;

        while (sumProbeg <= 100.0f)
        {
            denB++;
            probeg *= 1.1f;
            sumProbeg += probeg;
        }

        Console.WriteLine($"б) {denB}");
    }
}