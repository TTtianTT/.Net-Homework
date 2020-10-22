//订单明细类
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderApi.Models {
    public class OrderDetail {
        //key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemID{get;set;}
        //外键
        [ForeignKey("GoodsItemID")]
        public int GoodsItemID{get;set;}
        public Goods Goods { get; set; }

        [ForeignKey("OrderID")]
        public int OrderID{ get; set; }
        public int Amount{get;set;}
         public double TotalPrice {
             get =>  Goods.Price * Amount;
         }
    }
}