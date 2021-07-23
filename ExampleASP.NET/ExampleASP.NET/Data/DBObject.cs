using ExampleASP.NET.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data
{
    public class DBObject
    {
        public static void example(content content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
                content.AddRange(
                     new Car
                     {
                         Name = "tesla",
                         shortDesc = "asfsaf",
                         longDesc = "asdsa",
                         img = "/img/tesla.jpg",
                         price = 45000,
                         isFavourate = true,
                         available = true,
                         Category = Categories["Электро"]
                     },
                       new Car
                       {
                           Name = "tesla",
                           shortDesc = "vcxxcvcvx",
                           longDesc = "asdsa",
                           img = "/img/tesla.jpg",
                           price = 45000,
                           isFavourate = true,
                           available = true,
                           Category = Categories["Электро"]
                       },
                    new Car
                    {
                        Name = "Mersedes E",
                        shortDesc = "asfsaf",
                        longDesc = "asdsa",
                        img = "/img/Mersedes.jpg",
                        price = 20000,
                        isFavourate = true,
                        available = true,
                        Category = Categories["Классика"]
                    }

                    );
            content.SaveChanges();
        }
     

        static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category==null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName="Электро",desc = "Современный вид транспорта"},
                    new Category {categoryName="Классика", desc="Бензиновая"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                  
                } 
                return category;
            }
        }
    }
}
