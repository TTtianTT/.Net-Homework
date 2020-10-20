using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Goods
    {
        public int goodsID { get; }
        public string goodsName { get; }
        public int goodsPrice { get; }
        public Goods (int goodsID,string goodsName,int goodsPrice)
        {
            this.goodsID = goodsID;
            this.goodsName = goodsName;
            this.goodsPrice = goodsPrice;
        }
        public override string ToString()
        {
            return "货物编码："+goodsID+"货物名字："+goodsName+"货物价格："+goodsPrice;
        }
    }
}
