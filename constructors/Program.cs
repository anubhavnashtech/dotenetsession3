using System;
using System.Net.NetworkInformation;

namespace constructors
{
    public class CustomerDefault
    {
        public int Id;
        public string Name;

    }

    public class CustomerParameter
    {
        public int Id;
        public string Name;

        // public Customer()
        // {
        // }

        public CustomerParameter(int id)
        {
            this.Id = id;
        }

        public CustomerParameter(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }

    public  class Program
    {
         static void Main(string[] args)
         {
            // Default Customer
            //  DemoDefaultCustomer();

            // Parameterized Customer
            // DemoParameterizedConstructor();

            // Initialization Customer()
            DemoConstructorInitialization();
         }

         public static void DemoDefaultCustomer()
         {
            var customer = new CustomerDefault();
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
         }

         public static void DemoParameterizedConstructor()
         {
           // var customer = new CustomerParameter();
            var customer = new CustomerParameter(1, "John");
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
         }

         public static void DemoConstructorInitialization()
         {
            var customer = new Customer(1, "John");

            customer.Orders.Add(new Order());

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
            System.Console.WriteLine(customer.Orders.Count);


            var cust = new Customer()
            {
                 Id = 1,
                 Name = "John"
            };

         }
    }
}
