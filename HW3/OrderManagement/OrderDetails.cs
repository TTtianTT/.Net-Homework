using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderDetails
    {
        public Goods goods;//商品类实例
        public int goodsAmount { set; get; }
        public int goodsTotal { set; get; }

        public OrderDetails(Goods goods,int amount)
        {
            this.goods = goods;
            this.goodsAmount = amount;
            this.goodsTotal = goodsAmount * goods.goodsPrice;
        }
        public override string ToString()
        {
            //return "商品编号"+goods.goodsID+"商品数量："+goodsAmount+"商品总价："+goodsTotal;
            return goods.ToString() + "商品数量：" + goodsAmount + "商品总价：" + goodsTotal+"\n";
        }
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od != null && od.goods == goods;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
