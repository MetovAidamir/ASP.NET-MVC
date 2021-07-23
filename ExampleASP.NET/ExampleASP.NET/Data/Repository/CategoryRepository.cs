using ExampleASP.NET.Data.interfaces;
using ExampleASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly content DBcontent;
        public CategoryRepository(content content)
        {
            DBcontent = content;
        }
        public IEnumerable<Category> AllCategories => DBcontent.Category;
    }
}
