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
            Console.Write("Enter Radius value(in cm) = ");
            int r = Convert.ToInt32(Console.ReadLine());

            double c = 2 * 3.14 * r;
            double a = 3.14 * r * r;

            Console.WriteLine("Circumference of the circle = "+ c +"cm");
            Console.WriteLine("Area of the circle = " + a + "cm");
        }
    }
}
