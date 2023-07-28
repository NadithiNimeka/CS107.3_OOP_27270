using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Find
    {
        public void Scalar(int size, int[] arr1, int[] arr2)
        {
            //Scalar sum = Adding values of each element of an array
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += arr1[i] + arr2[i];
            }
            Console.WriteLine("\nScalar Sum: " + scalarSum);


            //Scalar Product
            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct += arr1[i] * arr2[i];
            }
            Console.WriteLine("Scalar Product: " + scalarProduct);
        }

        public void Vector(int size, int[] arr1, int[] arr2)
        {
            int[] resultArray = new int[size];

            //Vector sum = Adding values of each relative elements of an array and store them in third array
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = arr1[i] + arr2[i];
            }
            Console.Write("Vector Sum:");
            DisplayArray(resultArray);

            // Vector Product
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = arr1[i] * arr2[i];
            }
            Console.Write("Vector Product:");
            DisplayArray(resultArray);


            //display the vector sum and product
            void DisplayArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                Console.WriteLine();

            }
        }
    }
}
