using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinExample
{
    class CustomerRepository
    {
        public IList<Customer> CustomerRepo()
        {
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer() { Name="Rosy Paul" , Email="rosypaul@gmail.com" ,CustomerTypeId=3});

            customerList.Add(new Customer() { Name = "Rupo Paul", Email = "rupopaul@gmail.com", CustomerTypeId = 1 });

            customerList.Add(new Customer() { Name = "Smita Rai", Email = "smitarai@gmail.com", CustomerTypeId = 3 });

            customerList.Add(new Customer() { Name = "Lal Shito", Email = "lalshito@gmail.com", CustomerTypeId = 2 });

            customerList.Add(new Customer() { Name = "Kam Rok", Email = "kamrok@gmail.com", CustomerTypeId = 1 });

            customerList.Add(new Customer() { Name = "Kaushik Kaur", Email = "kaushikkaur@gmail.com", CustomerTypeId = 1 });

            return customerList;
        }
    }
}
