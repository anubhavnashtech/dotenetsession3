using System;

namespace classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
             System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

    }
    public  class Program
    {
         static void Main(string[] args)
         {

               // Object of class 
                // DemoObjectOfClass();

               // Static Member of Class
               // DemoStaticMemberOfClass();

         }

         public static void DemoObjectOfClass()
         {     
            Person person = new Person();
            person.Name = "Anubhav";
            person.Introduce("John");
         }

        public static void DemoStaticMemberOfClass()
         {     
            var person = Person.Parse("Anubhav");
            person.Introduce("John");
         }
    }
}
