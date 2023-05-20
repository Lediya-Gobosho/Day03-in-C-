using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFields
{
    internal class Person
    {
        
        private string lastName;

        public string FirstName { get; set; }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string upperFristName = FirstName.ToUpper();
                string lowerLasterName = LastName.ToLower();

                return upperFristName + " " + lowerLasterName;
            }
        }
    }
}
