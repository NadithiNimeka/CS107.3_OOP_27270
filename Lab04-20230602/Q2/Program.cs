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
            Console.Write("Enter the radius value:");
            double r = Convert.ToDouble(Console.ReadLine());

            FindValues values = new FindValues();
            /*
            values.FindArea(r);
            values.FindCircumference(r);
            */

            double a = values.FindArea(r);
            double c = values.FindCircumference(r);

            Console.WriteLine($"Area of the circle: {a}");
            Console.WriteLine($"Circumference of the circle: {c}");
        }
    }
}
