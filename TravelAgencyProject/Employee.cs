using System;
namespace TravelAgencyProject
{
    public class Employee
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Employee(string firstName, string surname, Guid? id)
        {
            FirstName = firstName;
            Surname = surname;
            Id = id ?? Guid.NewGuid();
        }
    }
}