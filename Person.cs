using System;

namespace Prog_3
{
    public class Person 
    {
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public int YearOfBirth  {get; set; }

        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int GetAge() 
        {
            var age = DateTime.Now.Year - YearOfBirth;
            return age;
        }

        public string GetFullName()
        {
            return $"Person: {FirstName} {LastName} is {GetAge()} years old";
        }
    }
}
