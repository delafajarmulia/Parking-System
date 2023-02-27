using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[ForeignKey("Type")]
        public MembershipType Type { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
