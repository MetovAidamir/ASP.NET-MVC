using ExampleASP.NET.Data.interfaces;
using ExampleASP.NET.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Controllers
{
    public class CarsController :Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;
        public CarsController(IAllCars iAllCars,ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCat;
        }
        
        public ViewResult List()
        {
            ViewBag.Title = "Страница автомобилей";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategry = "Автомобили";
            return View(obj);
        }
    }
}
