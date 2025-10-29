using System;
class Program
{
    static void Main()
    {
        float ploshad = 100.0f;
        float urozhainost = 20.0f;
        float obshiyUrozhay = 0.0f;
        int god = 1;

        float tempUrozhainost = 20.0f;
        int godA = 1;

        while (tempUrozhainost <= 22.0f)
        {
            godA++;
            tempUrozhainost *= 1.02f;
        }

        Console.WriteLine($"а) {godA}");

        float tempPloshad = 100.0f;
        int godB = 1;

        while (tempPloshad <= 120.0f)
        {
            godB++;
            tempPloshad *= 1.05f;
        }

        Console.WriteLine($"б) {godB}");

        ploshad = 100.0f;
        urozhainost = 20.0f;
        obshiyUrozhay = 0.0f;
        int godV = 0;

        while (obshiyUrozhay <= 800.0f)
        {
            godV++;
            obshiyUrozhay += ploshad * urozhainost;
            ploshad *= 1.05f;
            urozhainost *= 1.02f;
        }

        Console.WriteLine($"в) {godV}");
    }
}