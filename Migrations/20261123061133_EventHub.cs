using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp88.Migrations
{
    /// <inheritdoc />
    public partial class EventHub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    streatAdrees = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CityAdrees = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    countryAdrees = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventOrganizers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organizerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Isverification = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOrganizers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    uniqueAttendeeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modelout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    catorage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fkid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.uniqueAttendeeNumber);
                    table.ForeignKey(
                        name: "FK_Badges_Attends_fkid",
                        column: x => x.fkid,
                        principalTable: "Attends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    describtion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FristDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndtDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    maxmumattend = table.Column<int>(type: "int", nullable: false),
                    organizerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                    table.ForeignKey(
                        name: "FK_Events_EventOrganizers_organizerid",
                        column: x => x.organizerid,
                        principalTable: "EventOrganizers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "organizerprofiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    organizerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizerprofiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_organizerprofiles_EventOrganizers_organizerId",
                        column: x => x.organizerId,
                        principalTable: "EventOrganizers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badges_fkid",
                table: "Badges",
                column: "fkid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_organizerid",
                table: "Events",
                column: "organizerid");

            migrationBuilder.CreateIndex(
                name: "IX_organizerprofiles_organizerId",
                table: "organizerprofiles",
                column: "organizerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "organizerprofiles");

            migrationBuilder.DropTable(
                name: "Attends");

            migrationBuilder.DropTable(
                name: "EventOrganizers");
        }
    }
}
