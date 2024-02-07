using System;

namespace acessmodifiers
{
    public class Person
    {
        private DateTime _birthday;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthday = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthday;
        }
    }
    public  class Program
    {
         static void Main(string[] args)
         {
            var person = new Person();
            
            person.SetBirthdate(new DateTime(1994, 2, 4));
            System.Console.WriteLine(person.GetBirthdate());
         }
    }
}
