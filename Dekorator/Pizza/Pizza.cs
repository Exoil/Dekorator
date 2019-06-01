using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator.Pizzas
{
    public abstract class Pizza
    {
        protected string descritpion;
        protected double price;

        abstract public double GetPirce();
        abstract public string GetDescription();

        public override string ToString()
        {
            return $"Cena: {GetPirce()}, opis {GetDescription()}";
        }
    }
}
