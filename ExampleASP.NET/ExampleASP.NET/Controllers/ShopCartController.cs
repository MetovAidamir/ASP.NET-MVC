using ExampleASP.NET.Data.interfaces;
using ExampleASP.NET.Data.Models;
using ExampleASP.NET.Data.Repository;
using ExampleASP.NET.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Controllers
{
    public class ShopCartController:Controller
    {
        private readonly IAllCars _carRepository;
        private readonly Shopcart _shopcart;
        public ShopCartController(IAllCars carRepository, Shopcart shopcart)
        {
            _carRepository = carRepository;
            _shopcart = shopcart;
        }
        public ViewResult Index()
        {
            var items = _shopcart.GetShopCartItems();
            _shopcart.ListShopItems = items;
            var obj = new ShopCartViewModel
            {
                shopcart = _shopcart
            };
            return View(obj);
        }
        public RedirectToActionResult addTocart(int id)
        {
            var item = _carRepository.Cars.FirstOrDefault(i => i.id==id);
            if(item!=null)
            {
                _shopcart.AddtoCart(item);
            }
            return RedirectToAction("Index");
        }
        
    }
}
