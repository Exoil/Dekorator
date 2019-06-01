using System;
using System.Collections.Generic;
using System.Text;
using Dekorator.Pizzas;

namespace Dekorator.Additions
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
        
        public override string GetDescription()
        {
            return pizza.GetDescription();
        }

        public override double GetPirce()
        {
            return pizza.GetPirce();
        }
    }
}
