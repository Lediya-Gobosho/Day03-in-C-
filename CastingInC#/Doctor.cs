using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingInC_
{
    internal class Doctor
    {
        public string Specialization { get; set; }
        public string Name { get; internal set; }
        public int Age { get; internal set; }

        public void Diagnose()
        {
            Console.WriteLine("Am diagnosing a patient");
        }

        public static explicit operator Doctor(Person v)
        {
            throw new NotImplementedException();
        }
    }
}
