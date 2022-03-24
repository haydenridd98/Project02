using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02.Migrations
{
    public partial class MoreContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L,
                columns: new[] { "Available", "Date", "Time" },
                values: new object[] { true, "3/23/2022", "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 67L, true, "3/28/2022", null, null, 0, null, "9" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 66L, true, "3/28/2022", null, null, 0, null, "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 65L, true, "3/27/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 64L, true, "3/27/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 63L, true, "3/27/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 62L, true, "3/27/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 61L, true, "3/27/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 60L, true, "3/27/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 59L, true, "3/27/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 58L, true, "3/27/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 57L, true, "3/27/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 56L, true, "3/27/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 55L, true, "3/27/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 54L, true, "3/27/2022", null, null, 0, null, "9" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 53L, true, "3/27/2022", null, null, 0, null, "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 52L, true, "3/26/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 51L, true, "3/26/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 50L, true, "3/26/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 49L, true, "3/26/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 68L, true, "3/28/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 48L, true, "3/26/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 69L, true, "3/28/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 71L, true, "3/28/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 90L, true, "3/29/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 89L, true, "3/29/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 88L, true, "3/29/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 87L, true, "3/29/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 86L, true, "3/29/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 85L, true, "3/29/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 84L, true, "3/29/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 83L, true, "3/29/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 82L, true, "3/29/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 81L, true, "3/29/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 80L, true, "3/29/2022", null, null, 0, null, "9" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 79L, true, "3/29/2022", null, null, 0, null, "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 78L, true, "3/28/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 77L, true, "3/28/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 76L, true, "3/28/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 75L, true, "3/28/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 74L, true, "3/28/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 73L, true, "3/28/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 72L, true, "3/28/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 70L, true, "3/28/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 91L, true, "3/29/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 47L, true, "3/26/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 45L, true, "3/26/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 21L, true, "3/24/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 20L, true, "3/24/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 19L, true, "3/24/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 18L, true, "3/24/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 17L, true, "3/24/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 16L, true, "3/24/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 15L, true, "3/24/2022", null, null, 0, null, "9" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 14L, true, "3/24/2022", null, null, 0, null, "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 13L, true, "3/23/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 12L, true, "3/23/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 11L, true, "3/23/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 10L, true, "3/23/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 9L, true, "3/23/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 8L, true, "3/23/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 7L, true, "3/23/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 6L, true, "3/23/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 5L, true, "3/23/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 4L, true, "3/23/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 3L, true, "3/23/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 22L, true, "3/24/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 46L, true, "3/26/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 23L, true, "3/24/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 25L, true, "3/24/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 44L, true, "3/26/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 43L, true, "3/26/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 42L, true, "3/26/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 41L, true, "3/26/2022", null, null, 0, null, "9" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 40L, true, "3/26/2022", null, null, 0, null, "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 39L, true, "3/25/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 38L, true, "3/25/2022", null, null, 0, null, "19" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 37L, true, "3/25/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 36L, true, "3/25/2022", null, null, 0, null, "17" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 35L, true, "3/25/2022", null, null, 0, null, "16" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 34L, true, "3/25/2022", null, null, 0, null, "15" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 33L, true, "3/25/2022", null, null, 0, null, "14" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 32L, true, "3/25/2022", null, null, 0, null, "13" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 31L, true, "3/25/2022", null, null, 0, null, "12" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 30L, true, "3/25/2022", null, null, 0, null, "11" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 29L, true, "3/25/2022", null, null, 0, null, "10" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 28L, true, "3/25/2022", null, null, 0, null, "9" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 27L, true, "3/25/2022", null, null, 0, null, "8" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 26L, true, "3/24/2022", null, null, 0, null, "20" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 24L, true, "3/24/2022", null, null, 0, null, "18" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Date", "Email", "GroupName", "GroupSize", "PhoneNumber", "Time" },
                values: new object[] { 2L, true, "3/23/2022", null, null, 0, null, "9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 91L);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L,
                columns: new[] { "Available", "Date", "Time" },
                values: new object[] { false, "Mar 22, 2022", "8 A.M." });
        }
    }
}
