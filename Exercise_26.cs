using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eneter The String : ");
            string s = Console.ReadLine();

            // split the string by ' ' (space)
            string[] a = s.Split(' ');

            Console.Write("Reverse String is : ");
            for (int i = a.Length-1; i >= 0; i--)
            {
                Console.Write(a[i] +" ");
            }
            Console.WriteLine();
        }
    }
}