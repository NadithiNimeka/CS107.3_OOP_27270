using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} = Even", num);
            }

            if (num % 2 == 1)
            {
                Console.WriteLine("{0} = Odd", num);
            }
        }
    }
}
