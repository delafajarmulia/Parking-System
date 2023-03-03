using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystem.Migrations
{
    /// <inheritdoc />
    public partial class addview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_ViewMasterMembers_ViewMasterMemberId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberShipTypes_ViewMasterMembers_ViewMasterMemberId",
                table: "MemberShipTypes");

            migrationBuilder.DropTable(
                name: "ViewMasterMembers");

            migrationBuilder.DropIndex(
                name: "IX_MemberShipTypes_ViewMasterMemberId",
                table: "MemberShipTypes");

            migrationBuilder.DropIndex(
                name: "IX_Members_ViewMasterMemberId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ViewMasterMemberId",
                table: "MemberShipTypes");

            migrationBuilder.DropColumn(
                name: "ViewMasterMemberId",
                table: "Members");

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkingData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    HourlyRatesId = table.Column<int>(type: "int", nullable: false),
                    DatetimeIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatetimeOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountToPay = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.DropTable(
                name: "ParkingData");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.AddColumn<int>(
                name: "ViewMasterMemberId",
                table: "MemberShipTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViewMasterMemberId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ViewMasterMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMembership = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameMembership = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewMasterMembers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberShipTypes_ViewMasterMemberId",
                table: "MemberShipTypes",
                column: "ViewMasterMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_ViewMasterMemberId",
                table: "Members",
                column: "ViewMasterMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_ViewMasterMembers_ViewMasterMemberId",
                table: "Members",
                column: "ViewMasterMemberId",
                principalTable: "ViewMasterMembers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberShipTypes_ViewMasterMembers_ViewMasterMemberId",
                table: "MemberShipTypes",
                column: "ViewMasterMemberId",
                principalTable: "ViewMasterMembers",
                principalColumn: "Id");
        }
    }
}
