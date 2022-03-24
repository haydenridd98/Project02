using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 1L, false, "Mar 22, 2022", null, null, 0, null, "8 A.M." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
