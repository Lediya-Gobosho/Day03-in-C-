using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingInC_
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        internal string TestingAccessor;


        public void Speak()
        {
            Console.WriteLine("Hello Everyone");


        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }

        public static implicit operator Person(Programmer v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Person(Doctor v)
        {
            throw new NotImplementedException();
        }
    }
}
