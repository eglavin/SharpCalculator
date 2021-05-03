using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; } = 22;

    public PersonModel(string firstName, string lastName, int age = 0) {
        FirstName = firstName;
        LastName  = lastName;
        Age = age;
    }

    public string Name => $"{FirstName} {LastName}";

    public string Details(int readAge) => $"User {Name} is {readAge | Age} old.";
}
