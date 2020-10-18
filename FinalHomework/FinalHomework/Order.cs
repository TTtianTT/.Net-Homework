namespace OrderManagementDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;

    public class Order
    {
        //主键
        [Key]
        public int ID { get; set; }
        //外键
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime OrderTime { get; set; }
        public int TotalQuantity
        {
            get
            {
                int totalQuantity = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    totalQuantity += orderItem.Quantity;
                }
                return totalQuantity;
            }
        }
        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    //获得商品的价格
                    totalPrice += orderItem.GoodsItem.Price * orderItem.Quantity;
                }
                return totalPrice;
            }
        }
        public override string ToString()
        {
            StringBuilder showString = new StringBuilder($"Order ID:{ID}   {Customer}\n");
            showString.Append('-', 40);
            showString.AppendLine();
            //使用PadRight实现对齐
            showString.Append("ID".PadRight(5) + "|" + "Name".PadRight(20) + "|" +
                "Price".PadRight(10) + "|" + "Quantity".PadRight(8) + "\n");
            foreach (OrderItem orderItem in OrderItems)
            {
                showString.Append($"{orderItem}\n");
            }
            showString.Append('-', 45);
            showString.AppendLine();
            showString.Append($"Total quantity:{TotalQuantity}    Total price:{TotalPrice}\nOrder time:{OrderTime}\n");
            return showString.ToString();
        }
    }
}