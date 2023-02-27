using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystem.Migrations
{
    /// <inheritdoc />
    public partial class ViewMasterMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view ViewMasterMember as SELECT 
                                    dbo.Members.Id AS IdMember, 
                                    dbo.Members.Name AS NameMember, 
                                    dbo.Members.TypeId, 
                                    dbo.Members.Email AS EmailMember, 
                                    dbo.Members.PhoneNumber AS NomorHPMember, 
                                    dbo.Members.Address AS AddressMember, 
                                    dbo.Members.DateOfBirth AS DateOfBirthMember, 
                                    dbo.Members.Gender AS GenderMember, 
                                    dbo.MemberShipTypes.Id AS IdMembership, 
                                    dbo.MemberShipTypes.Name AS MembershipName
                                FROM     
                                    dbo.Members LEFT OUTER JOIN
                                    dbo.MemberShipTypes ON 
                                    dbo.Members.TypeId = dbo.MemberShipTypes.Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view ViewMasterMember;");
        }
    }
}
