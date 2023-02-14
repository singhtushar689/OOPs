using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOPs_Concept
{
    public abstract class Abstraction
    {
        public abstract void Ab();

        public void AC()
        {
            Console.WriteLine("We use AC in the summer");
        }
    }
    public class Car : Abstraction
    {
        public override void Ab()
        {
            Console.WriteLine("AB is AB Divillier");
        }
        public void AD()
        {
            Console.WriteLine("What is AD?");
        }
    }
}
