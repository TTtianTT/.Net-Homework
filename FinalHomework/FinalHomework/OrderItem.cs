using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderManagementDatabase
{
    public class OrderItem
    {
        [Key]
        public int ID { get; set; }
        //外键：该订单明细中的商品
        [ForeignKey("GoodsItemID")]
        public GoodsItem GoodsItem { get; set; }

        public int GoodsItemID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        public int OrderID { get; set; }

        public override string ToString()
        {
            return $"{GoodsItem.ID}".PadRight(5) + "|" +
                $"{ GoodsItem.Name}".PadRight(20) + "|" +
                $"{GoodsItem.Price}".PadRight(10) + "|" +
                $"{Quantity}".PadRight(5);
        }
    }
}