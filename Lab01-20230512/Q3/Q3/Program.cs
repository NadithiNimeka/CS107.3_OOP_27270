using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first value: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second value: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Summation of "+ num1 +" and "+ num2 +" is "+sum);
        }
    }
}
