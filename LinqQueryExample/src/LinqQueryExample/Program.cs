using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(){Firstname= "brad" , Lastname = "kalita" ,
                                        Customerid = "CS123" , Customertype = "good"});
            customers.Add(new Customer(){Firstname= "Debora" , Lastname = "Das" ,
                                        Customerid = "CS128" , Customertype =""});
            customers.Add(new Customer(){Firstname= "Punit" , Lastname = "Das" ,
                                        Customerid = "CS122" , Customertype = "bad"});
            customers.Add(new Customer(){Firstname= "Rupam" , Lastname = "Kalita" ,
                                        Customerid = "CS155" , Customertype = "good"});
            customers.Add(new Customer(){Firstname= "Sinu" , Lastname = "Paul" ,
                                        Customerid = "CS655" , Customertype = "bad"});
            customers.Add(new Customer(){Firstname= "Rohit" , Lastname = "Paul" ,
                                        Customerid = "CS145" , Customertype = "good"});
            customers.Add(new Customer(){Firstname= "Nord" , Lastname = "Kalita" ,
                                        Customerid = "CS657" , Customertype = ""});
            customers.Add(new Customer(){Firstname= "Arad" , Lastname = "Koch" ,
                                        Customerid = "CS183" , Customertype = "bad"});
            customers.Add(new Customer(){Firstname= "Ciaz" , Lastname = "Koch" ,
                                        Customerid = "CS142" , Customertype = "bad"});
            customers.Add(new Customer(){Firstname= "Pony" , Lastname = "Koch" ,
                                        Customerid = "CS142" , Customertype = "bad"});

            var ordering = new OrderingOperations();
            var quer = ordering.SortByName(customers);

            Console.WriteLine("In ascending order (SortByName):");
            foreach (var customer in quer)
            {
                Console.WriteLine("             "+customer.Firstname +" "+ customer.Lastname);
            }

            Console.WriteLine("In descending order (SortByNameInReverse):");
            var quer1 = ordering.SortByNameInReverse(customers);
               foreach (var customer in quer1)
            {
                Console.WriteLine("             "+customer.Firstname +" "+ customer.Lastname);
            }



             var quer2 = ordering.SortByType(customers);

            Console.WriteLine("In ascending order (SortByType):");
            foreach (var customer in quer2)
            {
                Console.WriteLine("             "+customer.Firstname +" "+ customer.Lastname);
            }




            

            //one way of traversing could be using for loop.....
            for(int i=0 ;i < customers.Count;i++)
            {
                if(customers[i].Customerid == "CS142")
                {
                    Console.WriteLine("Through for loop : "+customers[i].Firstname +" "+ customers[i].Lastname);
                }
            }

            //The same thing can be done using Linq query as shown.....
            var query = from c in customers where c.Customerid == "CS142" select c;
            //the 'query' won't get executed until 'query' is used viz invoked 
            var foundCustomer = query.First();       //if not found throws an exception
            //var foundCustomer = query.FirstOrDefault();
            //Console.WriteLine(foundCustomer);
            Console.WriteLine("Through Linq Query : "+foundCustomer.Firstname +" "+ foundCustomer.Lastname); 


            //The same thing also can be done using Linq method....

            var query1 = customers.FirstOrDefault(c => c.Customerid == "CS142") ;  
            Console.WriteLine("Through Method Syntax : "+query1.Firstname +" "+ query1.Lastname); 

            var query2 = customers.Where(c => c.Customerid == "CS142").Skip(1).FirstOrDefault() ;              
            Console.WriteLine("Through Method Syntax(skip 1) : "+query2.Firstname +" "+ query2.Lastname); 

        }
    }
}
