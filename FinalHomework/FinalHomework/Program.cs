using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Order Management System!");
            OrderService service = new OrderService();
            try
            {
                //获得用户ID
                int customerID = 0;
                String regOrSign = GetInput("1.register 2.sign in\n");
                switch (regOrSign)
                {
                    //注册
                    case "1":
                        String name = GetInput("Your name:");
                        String address = GetInput("Your address:");
                        customerID = service.AddCustomer(new Customer() { Name = name, Address = address });
                        Console.WriteLine($"Your ID:{customerID}");
                        break;
                    //登录
                    case "2":
                        customerID = int.Parse(GetInput("Your ID:"));
                        break;
                }
                while (true)
                {
                    String action = GetInput("1.add an order\t2.delete an order\t3.modify an order\t4.select the orders\nPlease select an action: ");
                    switch (action)
                    {
                        case "1":
                            //添加一个订单
                            Console.WriteLine("Add an order successful!");
                            Console.WriteLine("Your order ID is:" + service.AddOrder(new Order() { CustomerID = customerID, OrderTime = DateTime.Now }));

                            break;
                        case "2":
                            //删除订单
                            int orderID = int.Parse(GetInput("Order ID:"));
                            service.DeleteOrder(orderID);
                            Console.WriteLine("Delete the order successful!");
                            break;
                        case "3":
                            orderID = int.Parse(GetInput("Order ID:"));
                            String operation = GetInput(
                                "order time\tadd item\n" +
                                "delete item\tquantity\nPlease select an operation:"
                                );
                            String modifyData = "";
                            if (operation != "add item")
                            {
                                //修改后的数据
                                modifyData = GetInput("The data After modify:");
                            }
                            object data = null;
                            int goodsID = 0;
                            switch (operation)
                            {
                                case "order time":
                                    data = DateTime.Parse(modifyData);
                                    break;
                                case "add item":
                                    goodsID = Int32.Parse(GetInput("Goods ID:"));
                                    int quantity = Int32.Parse(GetInput("Quantity:"));
                                    data = new OrderItem() { GoodsItemID = goodsID, OrderID = orderID, Quantity = quantity };
                                    break;
                                case "delete item":
                                    goodsID = Int32.Parse(GetInput("Goods ID:"));
                                    break;
                                case "quantity":
                                    goodsID = Int32.Parse(GetInput("Quantity:"));
                                    data = Int32.Parse(modifyData);
                                    break;
                                default:
                                    throw new ArgumentException("Invalid argument!");
                            }
                            service.AlterOrder(orderID, operation, data, goodsID);
                            Console.WriteLine("Modify successful!");
                            break;
                        case "4":
                            string orderID_str = GetInput("Order ID:");
                            int orderId = orderID_str == "" ? int.MinValue : int.Parse(orderID_str);
                            List<Order> results = service.FindOrder(orderId);
                            Console.WriteLine("Result:");
                            foreach (Order order in results)
                            {
                                Console.WriteLine(order);
                            }
                            break;
                        default:
                            throw new ArgumentException("No such operation!");
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
        private static String GetInput(String tip)
        {
            Console.Write(tip);
            return Console.ReadLine();
        }
    }
}