using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02.Migrations
{
    public partial class InitialWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Appointments",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 1L, "Mar 22, 2022", "MichaelScott@gmail.com", "Michael Scott Fun Run for the Cure", 10, "801-777-8888", "8 A.M." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Appointments");
        }
    }
}
