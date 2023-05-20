using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInC_
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void Speak()
        {
            Console.WriteLine("Hello Everyone");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }
    }
}
