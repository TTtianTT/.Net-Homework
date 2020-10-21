using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApi.Models {
    //订单类
    public class Order {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID{get;set;}
        
        [ForeignKey("CustomerID")]
        public int CustomerID{get;set;}
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails{get;set;}
        public DateTime OrderTime{get;set;}
        public Order()
        {
            OrderTime = DateTime.Now;
        }
        public int TotalAmount{
            get {
                int totalAmount = 0;
                foreach (OrderDetail orderItem in OrderDetails)
                {
                    totalAmount += orderItem.Amount;
                }
                return totalAmount;
            }
        }
        public double TotalPrice {
            get =>  OrderDetails.Sum(item => item.TotalPrice);
        }


    }
}