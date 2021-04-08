using System;
namespace TravelAgencyProject
{
    public class Hotel
    {
        public string Name { get; private set; }
        public Guid Id { get; private set; }
        public decimal CostPerNight { get; set; }
        public float StarRating { get; set; }

        public Hotel(string name, decimal costPerNight, float starRating)
        {
            Name = name;
            Id = Guid.NewGuid();
            CostPerNight = costPerNight;
            StarRating = starRating;
        }
    }
}