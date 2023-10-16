using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_Value
{
    internal class Program
    {
        static int AbsoluteValue(int num)
        {
            return num < 0 ? -num : num;
        }

        static void Main(string[] args)
        {
            int num1 = 6832;
            int num2 = -392;

            int absValuel = AbsoluteValue(num1); // calling absolute value method
            int absValue2 = AbsoluteValue(num2);

            Console.WriteLine($"Absolute value of {num1} 1s {absValuel}");
            Console.WriteLine($"Absolute value of {num2} is {absValue2}");

            Console.ReadLine();

           
        } 
    }
}
