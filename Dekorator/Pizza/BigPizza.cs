using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Pizzas
{
    public class BigPizza : Pizza
    {
        public BigPizza()
        {
            descritpion = "BIg pizza";
            price = 20.0;
        }
        public override string GetDescription()
        {
            return descritpion;
        }

        public override double GetPirce()
        {
            return price;
        }
    }
}
