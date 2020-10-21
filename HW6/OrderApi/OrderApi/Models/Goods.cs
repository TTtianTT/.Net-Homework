//商品类
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderApi.Models {
    public class Goods{
        //key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsID{get;set;}
        //商品名
        [Required]
        public string Name{get;set;}
        //商品价格
        public double Price{get;set;}

        public static implicit operator Goods(double v)
        {
            throw new NotImplementedException();
        }
    }
}