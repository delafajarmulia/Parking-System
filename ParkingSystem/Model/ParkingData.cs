using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Model
{
    public class ParkingData
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public int? VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public int HourlyRatesId { get; set; }
        public DateTime DatetimeIn { get; set; }
        public DateTime DatetimeOn { get; set; }
        public int AmountToPay { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set;}
        public DateTime? DeletedAt { get; set;}
    }
}
