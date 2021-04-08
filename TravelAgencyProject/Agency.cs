using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TravelAgencyProject
{
    public class Agency
    {
        public List<Employee> Employees { get; set; }
        public List<Hotel> Hotels { get; set; }

        public Agency()
        {
            var employeeJsonFilePath = File.ReadAllText(@"data/employees.json");
            var hotelJsonFilePath = File.ReadAllText(@"data/hotels.json");

            var employeeData = JsonSerializer.Deserialize<List<Employee>>(employeeJsonFilePath);
            var hotelData = JsonSerializer.Deserialize<List<Hotel>>(hotelJsonFilePath);

            Employees = employeeData;
            Hotels = hotelData;
        }
    }
}
