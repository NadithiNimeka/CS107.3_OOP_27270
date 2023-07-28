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
            int[] arr = new int[10];
            Console.Write("Enter array Elements\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Class1.MinValue(Int16[], arr);
            Class1 val = new Class1();
            val.MinValue(arr);
            val.MaxValue(arr);
            val.average(arr);
            //val.reverse(arr);
        }
    }
}
