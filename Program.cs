using System;

class Program
{
    static void Main()
    {
        int[] liczby = { 12, 7, 45, -3, 22 };
        int maks = liczby[0];
        int min = liczby[0];

        for (int i = 1; i < liczby.Length; i++)
        {
            if (liczby[i] > maks)
                maks = liczby[i];
            if (liczby[i] < min)
                min = liczby[i];
        }

        Console.WriteLine("Największy element: " + maks);
        Console.WriteLine("Najmniejszy element: " + min);
    }
}
