using System;

class Code
{
    static void Main(String[] args)
    {
        int celcius;

        Console.Write("Enter Celcius : ");
        celcius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin : {0}K ", (double)(celcius + 275.15));
        Console.WriteLine("Farenheit : {0}F ", ((celcius * 9) / 5 + 32));
    }
}