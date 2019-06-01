using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Pizzas
{
    public class MediumPizza : Pizza
    {

        public MediumPizza()
        {
            descritpion = "Medium Pizza";
            price = 15.0;
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
