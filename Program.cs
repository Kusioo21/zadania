using System;

class Program
{
    static void Main()
    {
        int[] liczby = { 12, 7, 4, 19, 22, 33, 8 };

        int parzyste = 0;
        int nieparzyste = 0;

        foreach (int liczba in liczby)
        {
            if (liczba % 2 == 0)
                parzyste++;
            else
                nieparzyste++;
        }

        Console.WriteLine("Liczb parzystych: " + parzyste);
        Console.WriteLine("Liczb nieparzystych: " + nieparzyste);
    }
}
