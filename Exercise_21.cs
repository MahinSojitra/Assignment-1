using System;
using System.Collections.Generic;

class Code
{
    static bool checkInt(int fn)
    {
        if ((Math.Abs(fn - 100) <= 20) || (Math.Abs(fn - 200) <= 20))
        {
            return true;
        }
        return false;
    }

    static void Main(String[] args)
    {
        int first_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result : {0}", checkInt(first_num));
    }
}