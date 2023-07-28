using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Class1
    {
        public void Array(int size)
        {
            int[] array = new int[size*2];
            int index = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int userInput = int.Parse(Console.ReadLine());

                array[index++] = userInput;
                array[index++] = 0;
            }

            Console.WriteLine("Values inside the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
