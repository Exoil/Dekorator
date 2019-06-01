using Dekorator.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Additions
{
    public class DoubleCheese : PizzaDecorator
    {
        public DoubleCheese(Pizza pizza) :base(pizza)
        {

        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + " Double Cheese";
        }

        public override double GetPirce()
        {
            return pizza.GetPirce() + 3.00;
        }
    }
}
