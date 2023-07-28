using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i;

            Console.WriteLine("Input 10 numbers: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("number {0} : ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
;
            for (i = 0; i < 10; i++)
            {
                if (num[i]%2 == 0)
                {
                    Console.WriteLine("{0} = Even ", num[i]);
                }

                if (num[i]%2 == 1)
                {
                    Console.WriteLine("{0} = Odd ", num[i]);
                }

            }
            Console.ReadKey();
        }


    }
}
