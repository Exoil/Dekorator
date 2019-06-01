using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Pizzas
{
    public class SmallPizza : Pizza
    {

        public SmallPizza()
        {
            price = 10.50;
            descritpion = "Small Pizza";
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
