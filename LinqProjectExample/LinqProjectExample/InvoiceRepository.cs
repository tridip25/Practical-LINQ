using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjectExample
{
    public class InvoiceRepository
    {
        public List<Invoice> Retrieve()
        {
            return new List<Invoice>
            {
                new Invoice {
                    InvoiceId = 1, CustomerId = 1, InvoiceDate = new DateTime(2020, 3, 5), DueDate = new DateTime(2020, 8, 29),
                    Paid = true, Amount = 199.99M, NumberOfUnits = 20, DiscountPercent=10M
                },
                new Invoice {
                    InvoiceId = 2, CustomerId = 2, InvoiceDate = new DateTime(2018, 6, 20), DueDate = new DateTime(2019, 8, 27),
                    Paid = null, Amount = 300.00M, NumberOfUnits = 10, DiscountPercent=0M
                },
                new Invoice {
                    InvoiceId = 3, CustomerId = 3, InvoiceDate = new DateTime(2013, 6, 20), DueDate = new DateTime(2014, 10, 1),
                    Paid = null, Amount = 150.50M, NumberOfUnits = 30, DiscountPercent=15M
                },
                new Invoice {
                    InvoiceId = 4, CustomerId = 4, InvoiceDate = new DateTime(2019, 12, 20), DueDate = new DateTime(2020, 11, 29),
                    Paid = null, Amount = 185.99M, NumberOfUnits = 20, DiscountPercent=5M
                },
                new Invoice {
                    InvoiceId = 5, CustomerId = 5, InvoiceDate = new DateTime(2019, 8, 25), DueDate = new DateTime(2020, 10, 25),
                    Paid = true, Amount = 400.25M, NumberOfUnits = 30, DiscountPercent=30M
                }
            };
        }

        public List<Invoice> Retrieve(int customerId)
        {
            var result = this.Retrieve();
            return result.Where(i => i.CustomerId == customerId).ToList();
        }

        public decimal CalculateTotalAmountInvoiced(List<Invoice> invoiceList)
        {
            return invoiceList.Sum(inv => inv.TotalAmount);
        }

        public int CalculateTotalUnitSold(List<Invoice> invoiceList)
        {
            return invoiceList.Sum(inv => inv.NumberOfUnits);
        }

        public dynamic GetInvoiceTotalByIsPaid(List<Invoice> invoiceList)
        {
            var query = invoiceList.GroupBy(inv => inv.Paid ?? false,
                                            inv => inv.TotalAmount,
                                            (groupkey, invTotal) => new
                                            {
                                                Key = groupkey,
                                                InvoiceAmount = invTotal.Sum()
                                            });

            foreach(var item in query)
            {
                Console.WriteLine(item.Key +":"+ item.InvoiceAmount);
            }
            return query;
        }

        public dynamic GetInvoiceTotalByIsPaidAndMonth(List<Invoice> invoiceList)
        {
            var query = invoiceList.GroupBy(inv => new
            {
                IsPaid = inv.Paid ?? false,
                Month = inv.InvoiceDate.ToString("MMMM")
            }, inv => inv.TotalAmount,
            (groupKey, invTotal) => new
            {
                Key = groupKey,
                InvoiceAmount = invTotal.Sum()
            });

           

            foreach(var item in query)
            {
                Console.WriteLine(item.Key.IsPaid+"/"+item.Key.Month+":"+item.InvoiceAmount);
            }

            return query;
        }
    }
}
