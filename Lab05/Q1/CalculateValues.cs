using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class CalculateValues
    {
        public void Addition(int n1,int n2)
        {
            int A = n1 + n2;
            Console.WriteLine("\n{0} + {1} = {2}\n", n1, n2, A);
        }

        public void Subtraction(int n1, int n2)
        {
            int S = n1 - n2;
            Console.WriteLine("\n{0} - {1} = {2}\n", n1, n2, S);
        }

        public void Multiplication(int n1, int n2)
        {
            int M = n1 * n2;
            Console.WriteLine("\n{0} x {1} = {2}\n", n1, n2, M);
        }

        public void Divition(int n1, int n2)
        {
            int D = n1 / n2;
            Console.WriteLine("\n{0} / {1} = {2}\n", n1, n2, D);
        } 
    }
}
