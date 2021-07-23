using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data.Models
{
    public class ShopCartItem
    {
        [Key]
        public int itemID { get; set; }
        public Car car { get; set; }
        public int price { get; set; }
        public string ShopCartID { get; set; }
    }
}
