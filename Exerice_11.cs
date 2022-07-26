using System;

class Code
{
    static void Main(String[] args)
    {
        int age;

        Console.Write("Enter Your Age : ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You Older Than {0}.", age);
    }
}