namespace TravelAgencyProject
{
    public class Customer : Employee
    {
        public bool IsAcceptingMarketing { get; private set; }

        public Customer() : base()
        {
            IsAcceptingMarketing = true;
        }
    }
}