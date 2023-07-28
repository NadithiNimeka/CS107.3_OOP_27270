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
            Console.Write("Enter your salary: ");
            int sal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your tax rate: ");
            int taxrate = Convert.ToInt32(Console.ReadLine());

            int tax = (taxrate*sal1)/100;
            int sal2 = sal1 - tax ;

            Console.WriteLine("Your salary after tax is "+ sal2);
        }
    }
}
