using System;

class Program
{
    static void Main()
    {

        int[] liczby = { 5, 10, 15, 20, 25 };

        int suma = 0;

        for (int i = 0; i < liczby.Length; i++)
        {
            suma += liczby[i];
        }

        Console.WriteLine("Suma elementów tablicy wynosi: " + suma);
    }
}
