using System;

class Code
{
    static void Main(String[] args)
    {
        int number;

        Console.Write("Enter Number : ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0} {1} {2} {3}", number, number, number, number);
            Console.WriteLine("{0}{1}{2}{3}", number, number, number, number);
        }
    }
}