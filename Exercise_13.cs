using System;

class Code
{
    static void Main(String[] args)
    {
        int number;

        Console.Write("Enter Number : ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if ((i == 2 && j == 2) || (i == 3 && j == 2) || (i == 4 && j == 2))
                {
                    if (number>10)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write(number);
                }
            }
            Console.WriteLine();
        }
    }
}