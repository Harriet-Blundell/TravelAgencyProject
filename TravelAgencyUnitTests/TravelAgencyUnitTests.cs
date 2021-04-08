using System;
using TravelAgencyProject;
using Xunit;

namespace TravelAgencyUnitTests
{
    public class EmployeeTest
    {
        private const string defaultFirstName = "Tim";
        private const string defaultSurname = "Logan";

        [Fact]
        public void GetEmployeesFirstNameAndSurname()
        {
            var employee = new Employee
            {
                FirstName = defaultFirstName,
                Surname = defaultSurname
            };

            Assert.Equal(defaultFirstName, employee.FirstName);
            Assert.Equal(defaultSurname, employee.Surname);
        }

        [Fact]
        public void CheckEmployeeHasAnEmptyGuid()
        {
            var employee = new Employee
            {
                FirstName = defaultFirstName,
                Surname = defaultSurname
            };

            Assert.Equal(Guid.Empty, employee.Id);
        }
    }

    public class CustomerTest
    {
        private const string defaultFirstName = "Tim";
        private const string defaultSurname = "Logan";

        [Fact]
        public void CheckCustomerIsAcceptingMarketingConstructor()
        {
            var customer = new Customer
            {
                FirstName = defaultFirstName,
                Surname = defaultSurname
            };

            Assert.True(customer.IsAcceptingMarketing);
        }
    }

    public class HotelTest
    {
        private const string defaultHotelName = "Premier Inn";
        private const decimal defaultCostPerNight = 50;
        private const float defaultStarRating = 3;

        [Fact]
        public void GetsTheNameOfTheHotelName()
        {
            var hotel = new Hotel
            {
                Name = defaultHotelName, 
                CostPerNight = defaultCostPerNight, 
                StarRating = defaultStarRating
            };

            Assert.Equal(defaultHotelName, hotel.Name);
        }

        [Fact]
        public void ChecksTheHotelHasAnEmptyGuid()
        {
            var hotel = new Hotel
            {
                Name = defaultHotelName,
                CostPerNight = defaultCostPerNight,
                StarRating = defaultStarRating
            };

            Assert.Equal(Guid.Empty, hotel.Id);
        }

        [Fact]
        public void GetsTheCostPerNightOfTheHotel()
        {
            var hotel = new Hotel
            {
                Name = defaultHotelName,
                CostPerNight = defaultCostPerNight,
                StarRating = defaultStarRating
            };

            Assert.Equal(defaultCostPerNight, hotel.CostPerNight);
        }

        [Fact]
        public void GetsTheStarRatingOfTheHotel()
        {
            var hotel = new Hotel
            {
                Name = defaultHotelName,
                CostPerNight = defaultCostPerNight,
                StarRating = defaultStarRating
            };

            Assert.Equal(defaultStarRating, hotel.StarRating);
        }
    }

    public class AgencyTest
    {
        [Fact]
        public void CheckThatEmployeeListIsPopulated()
        {
            var agency = new Agency();

            Assert.True(agency.Employees.Count > 0);
        }

        [Fact]
        public void CheckThatHotelListIsPopulated()
        {
            var agency = new Agency();

            Assert.True(agency.Hotels.Count > 0);
        }
    } 
}
