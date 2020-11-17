using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceTeamApplicationTracker.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentOwner = table.Column<string>(nullable: true),
                    Application = table.Column<string>(nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: true),
                    ClosedDate = table.Column<DateTime>(nullable: true),
                    Point_of_Contact = table.Column<string>(nullable: true),
                    External_Ticket_Number = table.Column<string>(nullable: true),
                    Ticket_Cat = table.Column<string>(nullable: true),
                    Ticket_Description = table.Column<string>(nullable: true),
                    Resolution_Type = table.Column<string>(nullable: true),
                    Resolution_SubType = table.Column<string>(nullable: true),
                    Resolution_Description = table.Column<string>(nullable: true),
                    Work_Notes = table.Column<string>(nullable: true),
                    Last_UpdateDate = table.Column<DateTime>(nullable: false),
                    AgentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
