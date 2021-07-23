using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { set; get; }
        public bool isFavourate { set; get; }
        public bool available { set; get; }
        public int CategoryID { set; get; }
        public virtual Category Category { set; get; }
       
        
    }
}
