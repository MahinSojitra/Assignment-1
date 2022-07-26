using System;

class Code
{
    static void Main(String[] args)
    {
        String str;
        int position;

        Console.Write("Enter String : ");
        str = Console.ReadLine();
        Console.Write("Enter The Position Of Char You Want to Remove : ");
        position = Convert.ToInt32(Console.ReadLine());

        // remove one char from specified position
        Console.WriteLine("String : {0}", str.Remove(position, 1));
    }
}