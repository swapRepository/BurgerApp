using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerApp.Models
{
    public class Data:IData
    {
        public Burger GetData()
        {
            var burger = new Burger()
            {
                Name = "VegBurger",
                Quantity = 1,
                ExtraCheese = false
            };
            return burger;
        }
    }
}
