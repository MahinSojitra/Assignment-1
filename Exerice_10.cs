using System;

class Code
{
    static void Main(String[] args)
    {
        int x, y , z;

        Console.Write("Enter First Number : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Third Number : ");
        z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result Of Specified Numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {3}", x, y, z, (x + y)*z, (x*y + y*z));
    }
}