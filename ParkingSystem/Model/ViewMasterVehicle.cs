using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Model
{
    public class ViewMasterVehicle
    {
        public int IdVehicleType { get; set; }
        public string NameVehicleType { get; set; }
        public int VehicleId { get; set; }
        public int VehicleTypeId { get; set; }
        public int MemberId { get; set;}
        public string MemberName { get; set; }
        public string LicensePlate { get; set; }
        public string Notes { get; set; }
        public int IdMember { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
