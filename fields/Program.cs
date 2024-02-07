﻿using System;

namespace fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name): this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //......
        }
    }
    public class Order
    {

    }




    public  class Program
    {
         static void Main(string[] args)
         {
            
            var customer = new Customer(1);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            System.Console.WriteLine(customer.Orders.Count);

            customer.Promote();

            System.Console.WriteLine(customer.Orders.Count);

         }
    }
}
