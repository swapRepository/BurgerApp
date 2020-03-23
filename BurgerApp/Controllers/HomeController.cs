using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;
using BurgerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    [Route("[controller]")]
    public class HomeController:Controller
    {
        private Burger _data;
        public HomeController(IData data)
        {
             _data = data.GetData();
        }

        [Route("[action]")]
        public IActionResult Index(int id)
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Title = "Index",
                Burger =_data
            };
            return View(viewModel);
        }
    }
}