using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Order : IComparable
    {
        public int orderID { set; get; }
       // public string customerName { set; get; }

        public int total { set; get; }
        public Customer customer { set; get; }
        public List<OrderDetails> orderList { set; get; }
        public Order(int ID,Customer customer)
        {
            this.orderID = ID;
            this.customer = customer;
            this.orderList = new List<OrderDetails>();
            int x = 0;
            foreach(OrderDetails od in orderList)
            {
                x += od.goodsTotal;
            }
            this.total = x;
       }
        public override string ToString()
        {
            string s ="";
            foreach(OrderDetails o in orderList)
            {
                s = s + o.ToString();
            }
            return s;
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o != null && o.orderID == orderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(object obj)
        {
            {
                if (obj is Order)
                {
                    Order od = obj as Order;
                    {
                        return this.orderID - od.orderID;
                    }
                }
                else
                {
                    throw new ArgumentException("对象转化异常");
                }
            }
            throw new NotImplementedException();
        }
        public void AddDetails(OrderDetails orderDetails)
        {
            if (this.orderList.Contains(orderDetails))
            {
                throw new Exception($"orderDetail of the goods ({orderDetails.goods.goodsName}) exists in order {orderID}");
            }
            orderList.Add(orderDetails);
        }
    }
}
