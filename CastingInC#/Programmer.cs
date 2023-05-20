using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingInC_
{
    internal class Programmer
    {
        public string ProgrammingLanguage { get; set; }
        public string TestingAccessor { get; internal set; }
        public string Name { get; internal set; }
        public int Age { get; internal set; }

        private void Test()
        {
            TestingAccessor = "ok";
        }

        public void Code()
        {
            Console.WriteLine("Im coding with " + ProgrammingLanguage);
        }

        public static explicit operator Programmer(Person v)
        {
            throw new NotImplementedException();
        }
    }
}
