using System;

class Code
{
    static double getAbsolute(double fn, double sn)
    {
        if (fn > sn)
        {
            return (fn - sn);
        }
        return 0;
    }

    static void Main(String[] args)
    {
        double first_num, second_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Absolute Difference : {0}", getAbsolute(first_num, second_num));
    }
}