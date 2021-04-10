using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TravelAgencyProject
{
    public class Agency
    {
        public List<Employee> Employees { get; set; }
        public List<Hotel> Hotels { get; set; }
        private ILoadData _ILoadData { get; set; }

        public Agency(ILoadData loadData)
        {
            Employees = _ILoadData.LoadEmployeeJsonData();
            Hotels = _ILoadData.LoadHotelJsonData();
            _ILoadData = loadData;
        }
    }

    // using an interface as a blueprint for the class
    public interface ILoadData
    {
        List<Employee> LoadEmployeeJsonData();
        List<Hotel> LoadHotelJsonData();
    }

    // JsonFunctionality inherits from ILoadData to implement the interfaces
    public class JsonFunctionality : ILoadData
    {
        public List<Employee> LoadEmployeeJsonData()
        {
            var employeeJsonFilePath = File.ReadAllText(@"data/employees.json");
            var employeeData = JsonSerializer.Deserialize<List<Employee>>(employeeJsonFilePath);

            return employeeData;
        }

        public List<Hotel> LoadHotelJsonData()
        {
            var hotelJsonFilePath = File.ReadAllText(@"data/hotels.json");
            var hotelData = JsonSerializer.Deserialize<List<Hotel>>(hotelJsonFilePath);

            return hotelData;
        }
    }

}


// create an interface
// Separate all JSON-loading functionality into a separate class,
// then use an instance of that class to load your data
