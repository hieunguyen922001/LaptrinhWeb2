using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    new Pizza(1, "laptop Dell", 888.99M, Spiciness.Dell),
                    new Pizza(2, "Laptop MSI", 777.99M, Spiciness.Msi),
                    new Pizza(3, "Laptop HP", 654.99M, Spiciness.Hp)
                }
             });
    }
}

