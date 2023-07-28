using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int r = Convert.ToInt32(Console.ReadLine());

            double a = 3.14 * r * r;
            Console.WriteLine("Area of the Circle: "+ a);

        }
    }
}
