using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int VehicleTypeId { get; set; }
        public int MemberId { get; set; }
        public string LicensePlate { get; set; }
        public string Notes { get; set; }
    }
}
