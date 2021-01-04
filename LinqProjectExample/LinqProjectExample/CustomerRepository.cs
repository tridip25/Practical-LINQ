using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjectExample
{
    class CustomerRepository
    {
        public List<Customer> Retrieve()
        {
            var invoiceRepo = new InvoiceRepository();

            return new List<Customer>{
                new Customer {
                    Id = 1, FirstName = "Adam", LastName = "Smith", Email = "as@test.email", TypeId = 1, InvoiceList = invoiceRepo.Retrieve(1)
                },
                new Customer {
                    Id = 2, FirstName = "Jo", LastName = "Smith", Email = "jo.smith@test.email", TypeId = null, InvoiceList = invoiceRepo.Retrieve(2)
                },
                new Customer {
                    Id = 3, FirstName = "Joe", LastName = "Doh", Email = "jd@test.email", TypeId = 1, InvoiceList = invoiceRepo.Retrieve(3)
                },
                new Customer {
                    Id = 4, FirstName = "Jon", LastName = "Doe", Email = "jd2@test.email", TypeId = 2, InvoiceList = invoiceRepo.Retrieve(4)
                },
                new Customer {
                    Id = 5, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@test.email", TypeId = 3, InvoiceList = invoiceRepo.Retrieve(5)
                }
            };
        }

        public dynamic GetInvoiceTotalByCustomerType(List<Customer> customerList,
                                                    List<CustomerType> customerTypeList)
        {
            var customerTypeQuery = customerList.Join(customerTypeList,
                                        c => c.Id,
                                        ct => ct.TypeId,
                                        (c, ct) => new
                                        {
                                            CustomerInstance = c,
                                            CustomerTypeName = ct.TypeName
                                        });
            var query = customerTypeQuery.GroupBy(c => c.CustomerTypeName,
                                                    c => c.CustomerInstance.InvoiceList.Sum(inv => inv.TotalAmount),
                                                    (groupKey, invTotal) => new
                                                    {
                                                        Key = groupKey,
                                                        InvoicedAmount = invTotal.Sum()
                                                    });

            foreach (var item in query)
            {
                Console.WriteLine(item.Key +":"+ item.InvoicedAmount);
            }

            return query;
        }
    }
}
