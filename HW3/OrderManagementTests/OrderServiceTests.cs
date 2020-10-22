using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();
        [TestMethod()]
        public void AddOrderTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(4, allOrders.Count);
            CollectionAssert.Contains(allOrders, order0);
        }

        [TestMethod()]
        public void SelectedByIDTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(orderService.SelectedByID(0), order0);
        }

        [TestMethod()]
        public void SelectedByPriceTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(orderService.SelectedByPrice(135), order0);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            orderService.RemoveOrder(0);
            List<Order> allOrders = orderService.QueryAll();
            Assert.IsNull(allOrders);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            List<Order> allOrders = orderService.QueryAll();
        }

        [TestMethod()]
        public void SelectedByCustomerTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            orderService.SelectedByCustomer("张");
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(allOrders, orderService.SelectedByCustomer("张"));
        }

        [TestMethod()]
        public void SelectedByGoodsNameTest()
        {
            Customer customer = new Customer("张");
            Order order0 = new Order(0, customer);
            Goods goods = new Goods(9, "milk", 15);
            order0.AddDetails(new OrderDetails(goods, 1));
            orderService.AddOrder(order0);
            orderService.SelectedByGoodsName("milk");
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(allOrders, orderService.SelectedByGoodsName("milk"));
        }
    }
}