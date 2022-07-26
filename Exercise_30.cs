using System;

class Code
{
    static void Main(string[] args)
    {
        string str;
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        if (str.Length > 4)
        {
            Console.WriteLine(str.Substring(str.Length - 4)+" "+str.Substring(str.Length - 4) +" "+ str.Substring(str.Length - 4) +" "+ str.Substring(str.Length - 4));
        }
    }
}