using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TravelAgencyProject
{
    public class Agency
    {
        public List<Employee> Employees { get; set; }
        public List<Hotel> Hotels { get; set; }
        private ILoadData _ILoadData { get; set; }

        public Agency(ILoadData loadData)
        {

            Employees = Task.Run(async () => await _ILoadData.LoadEmployeeJsonData()).Result;
            Hotels = Task.Run(async () => await _ILoadData.LoadHotelJsonData()).Result;
            _ILoadData = loadData;
        }
    }

    // using an interface as a blueprint for the class
    public interface ILoadData
    {
        Task<List<Employee>> LoadEmployeeJsonData();
        Task<List<Hotel>> LoadHotelJsonData();
    }

    // JsonFunctionality inherits from ILoadData to implement the interfaces
    public class JsonFunctionality : ILoadData
    {
        public async Task<List<Employee>> LoadEmployeeJsonData()
        {
            var employeeJsonFilePath = await File.ReadAllTextAsync(@"data/employees.json");
            var employeeData = JsonSerializer.Deserialize<List<Employee>>(employeeJsonFilePath);

            return employeeData;
        }

        public async Task<List<Hotel>> LoadHotelJsonData()
        {
            var hotelJsonFilePath = await File.ReadAllTextAsync(@"data/hotels.json");
            var hotelData = JsonSerializer.Deserialize<List<Hotel>>(hotelJsonFilePath);

            return hotelData;
        }
    }

}


// create an interface
// Separate all JSON-loading functionality into a separate class,
// then use an instance of that class to load your data
