using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask
{
    internal class Reader
    {
        public int CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Borrowings> Borrowing { get; set; }
    }
}
