using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinExample
{
    class CustomerTypeIdRepository
    {
        public IList<CustomerType> CustomerTypeIdRepo()
        {
            List<CustomerType> customerTypeList = new List<CustomerType>();
            customerTypeList.Add(new CustomerType() {CustomerTypeId = 1 ,TypeName = "Corporate"});
            customerTypeList.Add(new CustomerType() { CustomerTypeId = 2, TypeName = "Government" });
            customerTypeList.Add(new CustomerType() { CustomerTypeId = 3, TypeName = "Semi-Government" });
            return customerTypeList;
        }
    }
}
