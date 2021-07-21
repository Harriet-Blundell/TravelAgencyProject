namespace TravelAgencyProject
{
    public class Customer : Employee
    {
        public bool IsAcceptingMarketing { get; set; }

        public Customer(bool isAcceptingMarketing)
        {
            IsAcceptingMarketing = isAcceptingMarketing;
        }
    }
}