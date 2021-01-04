using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyExample
{
    class Customer
    {
        public String CustomerName { get; set; }
        public int CustomerId { get; set; }
        public String Email { get; set; }
        public List<Invoice> Invoice { get; set; }

    }
}
