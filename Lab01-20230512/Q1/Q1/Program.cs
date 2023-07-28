using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your batch: ");
            int batch=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hii! "+ name);
            Console.WriteLine("your batch is " + batch);    
        }
    }
}
