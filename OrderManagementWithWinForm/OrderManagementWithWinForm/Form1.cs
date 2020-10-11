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
        OrderService orderService = new OrderService();

        public Form1()
        {
            InitializeComponent();

            Customer customer = new Customer("张三");
            Goods goods = new Goods(1, "milk", 12);
            Goods goods1 = new Goods(2, "apple", 52);

            Order order = new Order(1, customer);
            
            OrderDetails orderDetails = new OrderDetails(goods, 5);
            OrderDetails orderDetails1 = new OrderDetails(goods1, 2);
            order.AddDetails(orderDetails);
            order.AddDetails(orderDetails1);
            Customer customer1 = new Customer("李四");
            Order order1 = new Order(2, customer1);

            orderService.AddOrder(order);
            orderService.AddOrder(order1);

            bindingSource1.DataSource = orderService.orderlist;
            //bindingSource2.DataSource = orderService.orderlist;

            //dataGridView1.DataSource = orderService.orderlist;
            //dataGridView1.DataMember = order.orderList;
            //bindingSource1.DataSource = orderService;
            // dataGridView1.DataSource = orderService;
            // dataGridView1.DataMember = "orderlist";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void QueryAll()
        {
            bindingSource1.DataSource = orderService.orderlist;
            bindingSource1.ResetBindings(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                alarmText.Text = "请输入数字！";
            }
            int ID = Convert.ToInt32(textBox1.Text);

            bindingSource1.DataSource = orderService.SelectedByID(ID);
            if(orderService.SelectedByID(ID) == null)
            {
                alarmText.Text = "未找到信息！";
            }

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(orderService);
            form2.ShowDialog();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
