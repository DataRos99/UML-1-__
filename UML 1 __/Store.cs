using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___
{
    class Store
    {
        public void Start()
        {

            Pizza p1 = new Pizza("Vegetarian", "Cheese", 90);
            Pizza p2 = new Pizza("Marinara", "Tomatoes", 95);
            Pizza p3 = new Pizza("Vesuvio", "Peppers", 89);

            Customer c1 = new Customer("Simon");
            Customer c2 = new Customer("John");
            Customer c3 = new Customer("Noah");

            Order Order1 = new Order(p2, c1);
            Order Order2 = new Order(p1, c2);
            Order Order3 = new Order(p3, c3);

            Console.WriteLine(Order1);
            Console.WriteLine();
            Console.WriteLine(Order2);
            Console.WriteLine();
            Console.WriteLine(Order3);
        }


    }
}
