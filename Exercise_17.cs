using System;

class Code
{
    static bool CheckNum(int fn, int sn)
    {
        if ((fn < 0 && sn >= 0) || (fn >= 0 && sn < 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(String[] args)
    {
        int first_num, second_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result(One Num is Positive and Second Num is Negative) : {0}", CheckNum(first_num, second_num));
    }
}