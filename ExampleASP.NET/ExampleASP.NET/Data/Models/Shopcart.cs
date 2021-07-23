using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data.Models
{
    public class Shopcart
    {
        private readonly content DBcontent;
        public Shopcart(content content)
        {
            DBcontent = content;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }
        public static Shopcart GetShopcart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<content>();
            string shopCartID = session.GetString("CartID")?? Guid.NewGuid().ToString();
            session.SetString("CartID", shopCartID);
            return new Shopcart(context) { ShopCartId = shopCartID };
        }
        public void AddtoCart(Car car)
        {
            DBcontent.shopCartItems.Add(new ShopCartItem
            {

                ShopCartID = ShopCartId,
                car = car,
                price = car.price

            });
            DBcontent.SaveChanges();
        }
        public List<ShopCartItem> GetShopCartItems()
        {
            return DBcontent.shopCartItems.Where(c => c.ShopCartID == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
