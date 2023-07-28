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
            Console.Write("Enter 1st value: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd value: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            int sub = n1 - n2;
            int multi = n1 * n2;
            double div = n1 / n2;

            Console.WriteLine("Summation: "+ sum);
            Console.WriteLine("Subtraction: "+ sub);
            Console.WriteLine("Multiplication: "+ multi);
            Console.WriteLine("Divition: "+ div);
        }
    }
}
