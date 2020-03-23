using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;
using BurgerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
   
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Title = "Index",
                Burger = new Burger()
                {
                    Name = "VegBurger",
                    Quantity = 1,
                    ExtraCheese = false
                }


            };
            return View(viewModel);
        }
    }
}