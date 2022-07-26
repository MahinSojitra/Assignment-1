using System;

class Code
{
    static bool checkInt(int fn, int sn)
    {
        if (fn == 20 || sn == 20 || (fn+sn)==20)
        {
            return true;
        }
        return false;
    }

    static void Main(String[] args)
    {
        int first_num, second_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result : {0}", checkInt(first_num, second_num));
    }
}