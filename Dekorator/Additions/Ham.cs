using Dekorator.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Additions
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return pizza.GetDescription() + " Ham";
        }

        public override double GetPirce()
        {
            return pizza.GetPirce() + 2.87;
        }
    }
}
