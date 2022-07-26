using System;

class Code
{
    static void Main(String[] args)
    {
        int first_num, second_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} : {2}", first_num, second_num, (first_num + second_num));
        Console.WriteLine("{0} - {1} : {2}", first_num, second_num, (first_num - second_num));
        Console.WriteLine("{0} * {1} : {2}", first_num, second_num, (first_num * second_num));
        Console.WriteLine("{0} / {1} : {2}", first_num, second_num, (first_num / second_num));
        Console.WriteLine("{0} % {1} : {2}", first_num, second_num, (first_num % second_num));
    }
}