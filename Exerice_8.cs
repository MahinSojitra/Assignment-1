using System;

class Code
{
    static void Main(String[] args)
    {
        int number;

        Console.Write("Enter The Number : ");
        number = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i<=10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", number, i, (number * i));
        }
    }
}