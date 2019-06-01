using System;
using System.Collections.Generic;
using Dekorator.Pizzas;
using Dekorator.Additions;
namespace Dekorator
{

   


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pizza orderPizza;
            List<Pizza> orderList = new List<Pizza>();

            orderPizza = new MediumPizza();
            orderPizza = new DoubleCheese(orderPizza);
         //   Console.WriteLine(orderPizza);

            orderList.Add(orderPizza);

            orderPizza = new SmallPizza();
            orderPizza = new Olive(orderPizza);
            orderPizza = new Ham(orderPizza);

          //  Console.WriteLine(orderPizza);
            orderList.Add(orderPizza);


            orderPizza = new BigPizza();
            orderPizza = new Ham(orderPizza);
            orderPizza = new DoubleCheese(orderPizza);
            orderPizza = new Olive(orderPizza);
            orderList.Add(orderPizza);


            foreach(var pizza in orderList)
            {
                Console.WriteLine(pizza);
            }

            Console.ReadLine();


        }
    }
}
