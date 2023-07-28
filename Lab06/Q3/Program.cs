using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal obj1 = new Animal();
            Dog obj2 = new Dog();
            obj1.type();
            obj2.type();

        }
    }
}
