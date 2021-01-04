using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyExample
{
     class InvoiceRepository
    {
        public List<Invoice> InvoiceDetails(int CustomerId)
        {
            List<Invoice> InvoiceDetails = new List<Invoice>();
            InvoiceDetails.Add(new Invoice() { InvoiceId = 4 ,
                                                CustomerId = 1,
                                                InvoiceDate = new DateTime(2015,8,2),
                                                DueDate = new DateTime(2015 ,10,4),
                                                IsPaid = true});
            InvoiceDetails.Add(new Invoice()
            {
                InvoiceId = 3,
                CustomerId = 2,
                InvoiceDate = new DateTime(2016, 8, 2),
                DueDate = new DateTime(2016, 10, 4),
                IsPaid = true
            });
            InvoiceDetails.Add(new Invoice()
            {
                InvoiceId = 4,
                CustomerId = 3,
                InvoiceDate = new DateTime(2019, 7, 17),
                DueDate = new DateTime(2020, 12, 23),
                IsPaid = null
            });

            InvoiceDetails.Add(new Invoice()
            {
                InvoiceId = 52,
                CustomerId = 4,
                InvoiceDate = new DateTime(2019, 8, 18),
                DueDate = new DateTime(2019, 9, 21),
                IsPaid = true
            });

            List<Invoice> filteredList = InvoiceDetails.Where(i => i.CustomerId == CustomerId).ToList();
            return filteredList;
        }

        public IEnumerable<Customer> GetOverdueCustomers(List<Customer> customerList)
        {
            var query = customerList.SelectMany(c => c.Invoice.Where(i => (i.IsPaid?? true) == true),
                                                     (c, i) => c).Distinct();

            return query;
        }

    }
}
