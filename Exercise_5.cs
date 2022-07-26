using System;

class HelloWorld
{
    static void Main()
    {
        int first_num, second_num, temp;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());

        temp = first_num;
        first_num = second_num;
        second_num = temp;

        Console.WriteLine("First Number : {0}", first_num);
        Console.Write("Second Number : {0}", second_num);

    }
}