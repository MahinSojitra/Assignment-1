using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex_value = "10FA";
            int int_value = Convert.ToInt32(hex_value, 16); // 16 is base of Hexa-Decimal value
            Console.WriteLine("hex_value = {0}", hex_value);
            Console.WriteLine("int_value = {0}", int_value);
        }
    }
}
