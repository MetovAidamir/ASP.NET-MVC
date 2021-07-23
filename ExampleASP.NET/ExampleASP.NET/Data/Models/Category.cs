using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { get; set; }
        public string desc { set; get; }

        public List<Car> cars { get; set; }
    }
}
