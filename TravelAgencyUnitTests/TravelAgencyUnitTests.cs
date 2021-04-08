using System;
using System.Collections.Generic;
using TravelAgencyProject;
using Xunit;

namespace TravelAgencyUnitTests
{
    public class EmployeeTest
    {
        private string defaultFirstName = "Tim";
        private string defaultSurname = "Logan";

        [Fact]
        public void GetEmployeesFirstNameAndSurname()
        {
            var employee = new Employee(defaultFirstName, defaultSurname, null);

            Assert.Equal(defaultFirstName, employee.FirstName);
            Assert.Equal(defaultSurname, employee.Surname);
        }

        [Fact]
        public void CheckEmployeeHasAnEmptyGuid()
        {
            var employee = new Employee(defaultFirstName, defaultSurname, null);

            Assert.NotEqual(Guid.Empty, employee.Id);
        }
    }

    public class CustomerTest
    {
        private string defaultFirstName = "Tim";
        private string defaultSurname = "Logan";

        [Fact]
        public void CheckCustomerIsAcceptingMarketingConstructor()
        {
            var customer = new Customer(defaultFirstName, defaultSurname);

            Assert.True(customer.IsAcceptingMarketing);
        }
    }

    public class HotelTest
    {
        private string defaultHotelName = "Premier Inn";
        private decimal defaultCostPerNight = 50;
        private float defaultStarRating = 3;

        [Fact]
        public void GetsTheNameOfTheHotelName()
        {
            var hotel = new Hotel(defaultHotelName, defaultCostPerNight, defaultStarRating);

            Assert.Equal(defaultHotelName, hotel.Name);
        }

        [Fact]
        public void ChecksTheHotelHasAnEmptyGuid()
        {
            var hotel = new Hotel(defaultHotelName, defaultCostPerNight, defaultStarRating);

            Assert.NotEqual(Guid.Empty, hotel.Id);
        }

        [Fact]
        public void GetsTheCostPerNightOfTheHotel()
        {
            var hotel = new Hotel(defaultHotelName, defaultCostPerNight, defaultStarRating);

            Assert.Equal(defaultCostPerNight, hotel.CostPerNight);
        }

        [Fact]
        public void GetsTheStarRatingOfTheHotel()
        {
            var hotel = new Hotel(defaultHotelName, defaultCostPerNight, defaultStarRating);

            Assert.Equal(defaultStarRating, hotel.StarRating);
        }
    }

    public class AgencyTest
    {
        [Fact]
        public void CheckThatEmployeeListIsPopulated()
        {
            // arrange
            var agency = new Agency();

            var employeeData = new List<Employee>
            {
                new Employee("Tom", "Riddle", Guid.Parse("6eee7bea-0c7d-4b97-a106-254b4a0ba3ca")),
                new Employee("Sarah", "Coffee", Guid.Parse("e71599c2-20e1-47bc-92cb-3b02e5db21a5")),
                new Employee("Amir", "King", Guid.Parse("b27a089e-6a6b-46a5-9c76-b6648a671183"))
            };

            // assert

            Assert.Equal(employeeData, agency.Employees);
        }
    } 
}
