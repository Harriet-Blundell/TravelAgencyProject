namespace TravelAgencyProject
{
    public class Customer : Employee
    {
        public bool IsAcceptingMarketing { get; private set; }

        public Customer(string firstName, string surname) : base(firstName, surname, null)
        {
            FirstName = firstName;
            Surname = surname;
            IsAcceptingMarketing = true;
        }
    }
}