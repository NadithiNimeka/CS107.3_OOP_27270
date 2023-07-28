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
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            Class1 obj = new Class1();
            obj.Array(size);
        }
    }
}
