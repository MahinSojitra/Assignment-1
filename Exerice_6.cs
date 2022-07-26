using System;

class Code
{
    static void Main(String[] args)
    {
        int first_num, second_num, third_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Third Number : ");
        third_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication of Three Numbers : {0}", (first_num * second_num * third_num));
    }
}