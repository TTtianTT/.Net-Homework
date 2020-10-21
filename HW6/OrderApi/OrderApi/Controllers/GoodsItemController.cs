using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    //说明该类是控制器类
    [ApiController]
    //根路径：api/goodsitem
    [Route("api/[controller]")]
    public class GoodsItemController : ControllerBase
    {

        private readonly OrderContext orderDb;

        public GoodsItemController(OrderContext context)
        {
            this.orderDb = context;
        }

        //GET :api/goodsitem/id
        [HttpGet("{id}")]
        public ActionResult<Goods> GetGoods(int id)
        {
            //按商品号寻找商品
            var goods = orderDb.Goodss.FirstOrDefault(order => order.GoodsID == id);
            if (goods == null)
            {
                return NotFound();
            }
            return goods;
        }

        // GET: api/goodsitem
        // 按goods name查询
        [HttpGet]
        public ActionResult<List<Goods>> GetGoodsItems(string goodsName)
        {
            List<Goods> query = orderDb.Goodss.ToList();
            if(goodsName != null) {
                //按商品名字找
                query = query.Where(goods => goodsName == goods.Name).ToList();
            }
            return query;
        }

        //增加商品
        // POST: api/goodsitem
        [HttpPost]
        public ActionResult<Goods> PostGoodsItem(Goods goods)
        {
            try
            {
                orderDb.Goodss.Add(goods);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return goods;
        }

        //修改商品
        // PUT: api/goodsitem
        [HttpPut("{id}")]
        public ActionResult<Goods> PutGoodsItem(int id, Goods goods)
        {
            if (id != goods.GoodsID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(goods).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
        
        //删除商品
        // DELETE: api/goodsitem
        [HttpDelete("{id}")]
        public ActionResult DeleteGoodsItem(int id)
        {
            //有订单含有该商品是不能删除
            if(orderDb.OrderDetails.Count(item => item.GoodsItemID == id) > 0) {
                return BadRequest("This goods cannot be deleted!");
            }
            try
            {
                var goods = orderDb.Goodss.FirstOrDefault(goods => goods.GoodsID == id);
                if (goods != null)
                {
                    orderDb.Remove(goods);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}