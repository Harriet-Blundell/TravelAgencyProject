using System;
using System.Collections.Generic;
using Moq;
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
            // mocking ILoadData
            var mock = new Mock<ILoadData>();

            // Create employee data
            var employee1 = new Employee
            {
                FirstName = "John",
                Surname = "Dillon"
            };


            var employee2 = new Employee
            {
                FirstName = "Pope",
                Surname = "Francis"
            };

            var listOfEmployees = new List<Employee>()
            {
                employee1,
                employee2
            };

            mock.Setup(employee => employee.LoadEmployeeJsonData()).Returns(listOfEmployees);

        }

        [Fact]
        public void CheckThatHotelListIsPopulated()
        {
            // mock ILoadData
            var mock = new Mock<ILoadData>();

            // create hotel data
            var hotel1 = new Hotel
            {
                Name = "Premier Inn",
                CostPerNight = 35,
                StarRating = 4
            };

            var hotel2 = new Hotel
            {
                Name = "Hotel Bond",
                CostPerNight = 40,
                StarRating = 4
            };

            var listOfHotels = new List<Hotel>()
            {
                hotel1,
                hotel2
            };

            mock.Setup(hotel => hotel.LoadHotelJsonData()).Returns(listOfHotels);

        }
    } 
}
