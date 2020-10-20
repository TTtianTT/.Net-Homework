using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class OrderService
    {
        public OrderService()//构造函数
        {
            using (var management = new OrderManagement())
            {
                //若无商品（数据库初始化），默认添加商品
                if (management.Goodss.Count(goods => true) == 0)
                {
                    management.Goodss.Add(new Goods() { Name = "apple", Price = 6.8 });
                    management.Goodss.Add(new Goods() { Name = "bear", Price = 4.8 });
                    management.Goodss.Add(new Goods() { Name = "orange", Price = 2.8 });
                    management.Goodss.Add(new Goods() { Name = "lemon", Price = 7.8 });
                    management.SaveChanges();
                }
            }
        }
        public int AddOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentException("Cannot add an empty order!");
            }
            using (var management = new OrderManagement())
            {
                management.Orders.Add(order);
                management.SaveChanges();
            }
            return order.ID;
        }
        public void DeleteOrder(int orderID)
        {
            using (var management = new OrderManagement())
            {
                var order = management.Orders.Include("OrderItems").FirstOrDefault(o => o.ID == orderID);
                if (order != null)
                {
                    management.Orders.Remove(order);
                    management.SaveChanges();
                }
            }
        }
        public List<Order> FindOrder(int orderID)
        {
            using (var management = new OrderManagement())
            {
                var query = management.Orders.Include(o => o.OrderDetails.Select(i => i.Goods))
                                             .Include("Customer")
                                             .Where(order => orderID == int.MinValue || order.ID == orderID)
                                             .OrderBy(order => order.ID);
                return query.ToList();
            }
        }
        public void AlterOrder(int orderID, String alterType, object alterData, int orderItemID = 0)
        {
            using (var management = new OrderManagement())
            {
                var order = management.Orders.Include("OrderItems").FirstOrDefault(o => o.ID == orderID);
                if (order != null)
                {
                    switch (alterType)
                    {
                        case "customer": order.CustomerID = IsInt(alterData); break;
                        case "quantity":
                            int amount = order.OrderDetails.FirstOrDefault(
                                i => i.ID == orderItemID).Amount; ; break;
                        default: throw new ArgumentException("No such operation!");
                    }
                    management.SaveChanges();
                }
            }
        }
        private int IsInt(object data)
        {
            if (data is int)
            {
                return (int)data;
            }
            else
            {
                throw new ArgumentException("This is not a integer!");
            }
        }

    }
}
