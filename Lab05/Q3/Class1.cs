using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Class1
    {
        public void MinValue(int[] arr) {

            int min = arr[0];
            int i;
            for ( i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    arr[i] = min;
                }
            }
            Console.WriteLine("\nMinimum value in the array: {0}", arr[i]);
        }

        public void MaxValue(int[] arr)
        {
            int max = arr[0];
            int i;
            for ( i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    arr[i] = max;
                }
            }
            Console.WriteLine("\nMaximum value in the array: {0}", arr[i]);
        }

        public void average(int[] arr)
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("\nAverage value of the array: {0}", avg);

        }

        /*
        public void reverse(int[] arr)
        {
            int first = 0;
            int last = arr.Length - 1;
            while (first < last)
            {
                int temp = arr[first];
                arr[first] = arr[last];
                arr[last] = temp;
                first++;
                last--;
            }
            Console.WriteLine("Array in reverse order:");
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.WriteLine("{0}");
         }
           */

        

    }
}
