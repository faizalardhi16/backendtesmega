using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPKBs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AgreementNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BPKBNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BranchId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BPKBDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FakturNumber = table.Column<string>(type: "TEXT", nullable: true),
                    LocationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PoliceNo = table.Column<string>(type: "TEXT", nullable: true),
                    BPKBDateIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FakturDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPKBs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LocationName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BPKBs");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
