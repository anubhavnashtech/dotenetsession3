using System;

namespace properties
{
    public class Person
    {
        public Person(DateTime date)
        {
            Birthdate = date;
        }
        public DateTime Birthdate {get; private set;}

        public int Age
        {
            get
            {
              var timespan =   DateTime.Today - Birthdate;
              
              return timespan.Days/365;
            }
        }
    }



    public  class Program
    {
         static void Main(string[] args)
         {
            
            var person = new Person(new DateTime(1994,2,4));

            System.Console.WriteLine(person.Age);
         }
    }
}
