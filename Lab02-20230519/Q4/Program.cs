using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("" + num + " is an Even Number");
            }
            if (num % 2 == 1)
            {
                Console.WriteLine("" + num + " is an Odd Number");
            }
        }
    }
}
