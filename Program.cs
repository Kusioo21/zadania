using System;

class Program
{
    static void Main()
    {
        string[] imiona = { "Kasia", "Marek", "Ola", "Piotr", "Ania" };

        for (int i = imiona.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(imiona[i]);
        }
    }
}
