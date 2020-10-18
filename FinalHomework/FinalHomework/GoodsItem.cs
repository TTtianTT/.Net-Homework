using System.ComponentModel.DataAnnotations;

namespace OrderManagementDatabase
{
    public class GoodsItem
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}