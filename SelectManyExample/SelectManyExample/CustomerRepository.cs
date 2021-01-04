using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyExample
{
    class CustomerRepository
    {
       
        public List<Customer> CustomerList()
        {
            InvoiceRepository p = new InvoiceRepository();
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer()
            {
                CustomerName = "Rupam Kalita",
                CustomerId = 1,
                Email = "rupamkalita@gmail.com",
                Invoice = p.InvoiceDetails(1)
            });
            customerList.Add(new Customer()
            {
                CustomerName = "Roshan Das",
                CustomerId = 2,
                Email = "roshandas@gmail.com",
                Invoice = p.InvoiceDetails(2)
            });
            customerList.Add(new Customer()
            {
                CustomerName = "Rocky Borah",
                CustomerId = 3,
                Email = "rockyborah@gmail.com",
                Invoice = p.InvoiceDetails(3)
            });
            customerList.Add(new Customer()
            {
                CustomerName = "Puk Rah",
                CustomerId = 4,
                Email = "Pukrah@gmail.com",
                Invoice = p.InvoiceDetails(4)
            });
            return customerList;
        }
    }
}
