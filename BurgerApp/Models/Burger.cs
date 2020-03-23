using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerApp.Models
{
    public class Burger
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool ExtraCheese { get; set; }
    }
}
