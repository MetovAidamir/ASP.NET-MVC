using ExampleASP.NET.Data.interfaces;
using ExampleASP.NET.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly content DBcontent;
        public CarRepository(content content)
        {
            DBcontent = content;
        }
        public IEnumerable<Car> Cars => DBcontent.Car.Include(c=>c.Category);

        public IEnumerable<Car> getFavCars => DBcontent.Car.Where(p => p.isFavourate).Include(c => c.Category);

        public Car getObjCar(int CarID) => DBcontent.Car.FirstOrDefault(p => p.id == CarID);
        
    }
}
