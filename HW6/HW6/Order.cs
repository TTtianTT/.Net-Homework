using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (OrderDetail orderDetail in OrderDetails)
                {
                    //获得商品的价格
                    totalPrice += orderDetail.Goods.Price * orderDetail.Amount;
                }
                return totalPrice;
            }
        }

    }
}
