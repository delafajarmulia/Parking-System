using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystem.Migrations
{
    /// <inheritdoc />
    public partial class ProductionRatingAveragesView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMembership = table.Column<int>(type: "int", nullable: false),
                    NameMembership = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
