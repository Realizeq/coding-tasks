using System;
class Program
{
    static void Main()
    {
        int chislo = 12345;

        int obratno = 0;
        int temp = chislo;
        while (temp > 0)
        {
            int poslednyaya = temp % 10;
            obratno = obratno * 10 + poslednyaya;
            temp = temp / 10;
        }
        Console.WriteLine("а) " + obratno);

        string s_dvoikami = "2" + chislo + "2";
        Console.WriteLine("б) " + s_dvoikami);

        int a = 2;
        string stroka = chislo.ToString();
        string bez_a = "";
        for (int i = 0; i < stroka.Length; i++)
        {
            if (stroka[i] != '2')
            {
                bez_a = bez_a + stroka[i];
            }
        }
        Console.WriteLine("в) " + bez_a);

        if (stroka.Length > 1)
        {
            char pervaya = stroka[0];
            char poslednyaya = stroka[stroka.Length - 1];
            string seredina = "";
            for (int i = 1; i < stroka.Length - 1; i++)
            {
                seredina = seredina + stroka[i];
            }
            string obmen = poslednyaya + seredina + pervaya;
            Console.WriteLine("г) " + obmen);
        }
        else
        {
            Console.WriteLine("г) " + chislo);
        }

        string udvoennoe = chislo.ToString() + chislo.ToString();
        Console.WriteLine("д) " + udvoennoe);
    }
}