using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Model
{
    public class HourlyRate
    {
        public int Id { get; set; }
        public int? MembershipId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set;}
        public DateTime? DeletedAt { get; set;}
    }
}
