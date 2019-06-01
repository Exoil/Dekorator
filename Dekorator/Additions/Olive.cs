using Dekorator.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Additions
{
    public class Olive : PizzaDecorator
    {
        public Olive(Pizza pizza) : base(pizza)
        {

        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + " Olive";
        }

        public override double GetPirce()
        {
            return pizza.GetPirce() + 2.0;
        }
    }
}
