using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementWithWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OrderService os = new OrderService();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("zhang");
            Goods goods = new Goods(121, "ha", 23);
            Goods goods1 = new Goods(132, "sa", 17);
            Order od = new Order(1,customer);

            OrderDetails orderDetails = new OrderDetails(goods,5);
            OrderDetails orderDetails1 = new OrderDetails(goods1, 7);

            od.orderList.Add(orderDetails);
            od.orderList.Add(orderDetails1);

            os.AddOrder(od);

            foreach(Order oddd in os.orderList)
            {
                foreach(OrderDetails details in oddd.orderList)
                {
                    listBox1.Items.Add(details.ToString());
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
