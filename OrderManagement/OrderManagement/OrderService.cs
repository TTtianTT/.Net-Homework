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
        //public List<Order> olist = new List<Order>();
        public static List<Order> olist = new List<Order>();

        public static void AddOrder()
        {
            Customer cs = new Customer("s"); ;
            Order od = new Order(0,cs);//构造ID为0的空订单
            olist.Add(od);
        }
        public static void RemoveOrder(int ID) 
        {
            try
            {
                foreach(Order od in olist)
                {
                    if (od.orderID == ID){ olist.Remove(od); }
                }
            }
            catch
            {
                Console.WriteLine("Error" );
            }
        }
        public static void UpdateOrder(Order order)
        {
            if (olist.Contains(order))
            {
                throw new Exception($"orderlist already exists this");
            }
            olist.Add(order);
        }
        public static List<Order> SelectedByID(int id)
        {
            var query = from od in olist where od.orderID == id select od;
            List<Order> ol = query.ToList();
            return ol;
        }
        public static List<Order> SelectedByCustomer(string name)
        {
            var query = from od in olist where od.customer.customerName == name select od;
            List<Order> ol = query.ToList();
            return ol;
        }
        public static List<Order> SelectedByPrice(int price)
        {
            var query = from od in olist where od.total == price select od;
            List<Order> ol = query.ToList();
            return ol;
        }
        public static void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, OrderService.olist);
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
