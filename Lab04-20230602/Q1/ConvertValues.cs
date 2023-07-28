using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class ConvertValues
    {
        /*
        //question01part1
        public void kilometerTOmeter ()
        {
            Console.Write("Enter a value in KM(Kelometer): ");
            int km = Convert.ToInt32 (Console.ReadLine());

            int m = km * 1000;

            Console.WriteLine("" + km + " in M(meters) = " + m);
        }
        */


        
        //question1part2
        /*
        public void kilometerTOmeter(int km, int m)
        {
            Console.Write("Enter a value in KM(Kelometer): ");
            km = Convert.ToInt32(Console.ReadLine());

            m = km * 1000;

            Console.WriteLine("" + km + " in M(meters) = " + m);
        }
        */
        


        //question1part3
        public int kilometerTOmeter(int km, int m)
        {
            Console.Write("Enter a value in KM(Kelometer): ");
            km = Convert.ToInt32(Console.ReadLine());

            m = km * 1000;

            Console.WriteLine("" + km + " in M(meters) = " + m);

            return kilometerTOmeter(km, m);
        }
    }
}
