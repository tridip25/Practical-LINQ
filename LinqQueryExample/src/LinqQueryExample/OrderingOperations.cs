using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryExample
{
    public class OrderingOperations
    {
        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.Lastname).ThenBy(c => c.Firstname);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.Lastname).ThenByDescending( c => c.Firstname);
            //or
            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
               return customerList.OrderBy(c => c.Customertype); //if it has any null values will come in the top

             //  return customerList.OrderByDescending(c => c.Customertype).ThenBy(c => c.Customertype);
        }

    
    }
}