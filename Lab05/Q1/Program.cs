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
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Divition\n");

            Console.Write("Enter Your Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            CalculateValues cal = new CalculateValues();

            if (choice == 1)
            {
                cal.Addition(n1 , n2);
                
                
            }
            
            if (choice == 2)
            {
                cal.Subtraction(n1 , n2);
            }

            if(choice == 3)
            {
                cal.Multiplication(n1, n2);
            }

            if (choice == 4)
            {
                cal.Divition(n1, n2);
            }


        }
    }
}
