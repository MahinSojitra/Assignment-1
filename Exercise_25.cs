using System;

public class Code
{
    static void Main()
    {
        int number, reminder, Sum = 0; 

        Console.Write("Enter Number : ");
        number = Convert.ToInt32(Console.ReadLine());

        while(number != 0)
        {
            reminder = number % 10;
            number = number / 10;
            Sum = Sum + reminder;
        }

        Console.WriteLine("Sum Of Number : "+Sum);
    }
}