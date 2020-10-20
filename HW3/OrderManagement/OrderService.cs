using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace OrderManagement
{
    public class OrderService
    {
        private List<Order> orderlist;
        public OrderService()
        {
            orderlist = new List<Order>();
        }
        public List<Order> QueryAll()
        {
            return orderlist;
        }

        public void AddOrder(Order order)//向orderList中增加一个订单
        {
            if(orderlist.Contains(order))
            {
                throw new ApplicationException("这个订单已存在！");
            }
            orderlist.Add(order);
        }
        public void RemoveOrder(int ID) //删除指定ID的订单
        {
            var query = orderlist.Where(odr => odr.orderID == ID);
            if(query == null)
            {
                throw new ApplicationException("不存在相应ID的订单，删除失败");
            }
            orderlist.RemoveAll(odrr => odrr.orderID == ID);
        }
        public void UpdateOrder(Order order)//更新订单列表
        {
            if (orderlist.Contains(order))
            {
                throw new Exception($"orderlist already exists this");
            }
            orderlist.Add(order);
        }
        public List<Order> SelectedByID(int id)
        {
            var query = from od in orderlist where od.orderID == id select od;
            List<Order> ol = query.ToList();
            return ol;
        }
        public List<Order> SelectedByCustomer(string name)
        {
            var query = from od in orderlist where od.customer.customerName == name select od;
            List<Order> ol = query.ToList();
            return ol;
        }
        public List<Order> SelectedByPrice(int price)
        {
            var query = from od in orderlist where od.total == price select od;
            List<Order> ol = query.ToList();
            return ol;
        }
        public List<Order> SelectedByGoodsName(string goodsName)
        {
            var query = orderlist.Where(
                odr => odr.orderList.Exists(
                    detail => detail.goods.goodsName == goodsName
                ));
            List<Order> ol = query.ToList();
            return ol;
        }
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, this.orderlist);
            }
        }
        public static List<Order> Import()
        {
            using (FileStream fs = new FileStream("s.xml",FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                List<Order> olist = (List<Order>)xmlSerializer.Deserialize(fs);
                return olist;
            }
        }
    }
}
