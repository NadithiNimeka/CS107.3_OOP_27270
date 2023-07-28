using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
     class Animal
    {
        public void type() {

            Console.WriteLine("I am an animal,");
        }
    }

    class Dog : Animal
    {
        public void type()
        {
            Console.Write("I have 4 legs.\n");
        }
    }
}
