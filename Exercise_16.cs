using System;

class Code
{
    static void Main(String[] args)
    {
        String str;

        Console.Write("Enter String : ");
        str = Console.ReadLine();

        str = str.Insert(0, "M");
        str = str.Insert(str.Length, "M");

        Console.WriteLine("String : "+str);
    }
}