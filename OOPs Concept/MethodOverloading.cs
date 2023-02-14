using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    public class MethodOverloading
    {
        public void Addition(int a,int b)
        {     
            int c = a + b;
            Console.WriteLine("The sum of two number is "+ c);
        }
        public void Addition(string a)
        {
            Console.WriteLine("It is method Overloading");
        }
    }
}
