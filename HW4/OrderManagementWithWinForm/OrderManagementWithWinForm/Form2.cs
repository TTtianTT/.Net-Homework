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
    public partial class Form2 : Form
    {
        public OrderService orderService;
        public Form2(OrderService orderService)
        {

            InitializeComponent();
            this.orderService = orderService;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(orderIDtextBox.Text);
            string name = customerNametextBox.Text;
            Customer customer = new Customer(name);
            Order order = new Order(ID, customer);
            if (orderService.SelectedByID(ID) != null)
            {
                orderService.RemoveOrder(ID);
                orderService.AddOrder(order);
            }
            else
            {

                orderService.AddOrder(order);
            }

        }
    }
}
