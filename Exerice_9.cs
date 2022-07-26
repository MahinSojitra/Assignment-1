using System;

class Code
{
    static void Main(String[] args)
    {
        int first_num, second_num, third_num, fourth_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Third Number : ");
        third_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Fourth Number : ");
        fourth_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Average Of Above Four Numbers is {0}.", (double)(first_num + second_num + third_num + fourth_num) / 4);
    }
}