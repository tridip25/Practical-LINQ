using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousExample
{
    class CustomerRepository
    {
        public IList<Customer> Customers()
        {
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer() {FirstName = "Brad" , LastName = "Potato" , EmailAddress = "a@abc.com"});
            customerList.Add(new Customer() { FirstName = "Gotte", LastName = "Piyaj", EmailAddress = "piyaj@gmail.com" });
            customerList.Add(new Customer() { FirstName = "Snoopy", LastName = "Hazarika", EmailAddress = "snop@yahoo.com" });
            customerList.Add(new Customer() { FirstName = "Laura", LastName = "Paul", EmailAddress = "paul@abc.com" });
            return customerList;
        }
    }
}
