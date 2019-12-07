using Examples.DecimalHelper.Helpers;
using System;

namespace Examples.DecimalHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 12.129997932m;
            decimal num2 = 120.349958m;

            Console.WriteLine($"num1 = {num1.Truncate(4)}"); // imprime 12.1299
            Console.WriteLine($"num2 = {num2.Truncate(3)}"); // imprime 120.349
            Console.WriteLine($"num3 = {99.122958m.Truncate(5)}"); // imprime 99.12295
        }
    }
}
