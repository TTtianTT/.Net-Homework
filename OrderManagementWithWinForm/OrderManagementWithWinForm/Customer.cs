using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithWinForm
{
    public class Customer
    {
        public string customerName { get; }
        public Customer(string name)
        {
            this.customerName = name;
        }
        public override string ToString()
        {
            return "客户名字：" + customerName;
        }

    }
}
