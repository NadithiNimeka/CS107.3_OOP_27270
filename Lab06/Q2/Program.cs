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
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] resultArray = new int[size];

            Console.WriteLine("\nEnter values for Array 1:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nEnter values for Array 2:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ",i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            Find val = new Find();
            val.Scalar(size, arr1, arr2);
            val.Vector(size, arr1, arr2);



        }
    }
}
