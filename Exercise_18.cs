using System;

class Code
{
    static int Sum(int fn, int sn)
    {
        if (fn == sn)
        {
            return (fn*3);
        }
        else
        {
            return fn + sn;
        }
    }

    static void Main(String[] args)
    {
        int first_num, second_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result : {0}", Sum(first_num, second_num));
    }
}