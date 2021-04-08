using System;

namespace TravelAgencyProject
{
    public class Hotel
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public decimal CostPerNight { get; set; }
        public float StarRating { get; set; }
    }
}