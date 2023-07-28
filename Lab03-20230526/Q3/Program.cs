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
            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int remin;

                remin = num % 10;
                sum = sum + remin;
                num = num / 10;
            }

            Console.WriteLine($"The Sum of Digits is : {sum}");
            Console.ReadKey();
        }
    }
}
