using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project02.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<DateTime>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 1, null, null, 0, null, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 95, null, null, 0, null, new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 94, null, null, 0, null, new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 93, null, null, 0, null, new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 92, null, null, 0, null, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 91, null, null, 0, null, new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 90, null, null, 0, null, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 89, null, null, 0, null, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 88, null, null, 0, null, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 87, null, null, 0, null, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 86, null, null, 0, null, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 85, null, null, 0, null, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 84, null, null, 0, null, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 83, null, null, 0, null, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 96, null, null, 0, null, new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 82, null, null, 0, null, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 80, null, null, 0, null, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 79, null, null, 0, null, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 78, null, null, 0, null, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 77, null, null, 0, null, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 76, null, null, 0, null, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 75, null, null, 0, null, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 74, null, null, 0, null, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 73, null, null, 0, null, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 72, null, null, 0, null, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 71, null, null, 0, null, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 70, null, null, 0, null, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 69, null, null, 0, null, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 68, null, null, 0, null, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 81, null, null, 0, null, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 97, null, null, 0, null, new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 98, null, null, 0, null, new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 99, null, null, 0, null, new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 128, null, null, 0, null, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 127, null, null, 0, null, new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 126, null, null, 0, null, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 125, null, null, 0, null, new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 124, null, null, 0, null, new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 123, null, null, 0, null, new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 122, null, null, 0, null, new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 121, null, null, 0, null, new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 120, null, null, 0, null, new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 119, null, null, 0, null, new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 118, null, null, 0, null, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 117, null, null, 0, null, new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 116, null, null, 0, null, new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 115, null, null, 0, null, new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 114, null, null, 0, null, new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 113, null, null, 0, null, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 112, null, null, 0, null, new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 111, null, null, 0, null, new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 110, null, null, 0, null, new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 109, null, null, 0, null, new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 108, null, null, 0, null, new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 107, null, null, 0, null, new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 106, null, null, 0, null, new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 105, null, null, 0, null, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 104, null, null, 0, null, new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 103, null, null, 0, null, new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 102, null, null, 0, null, new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 101, null, null, 0, null, new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 100, null, null, 0, null, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 67, null, null, 0, null, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 66, null, null, 0, null, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 65, null, null, 0, null, new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 64, null, null, 0, null, new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 30, null, null, 0, null, new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 29, null, null, 0, null, new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 28, null, null, 0, null, new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 27, null, null, 0, null, new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 26, null, null, 0, null, new DateTime(2022, 3, 24, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 25, null, null, 0, null, new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 24, null, null, 0, null, new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 23, null, null, 0, null, new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 22, null, null, 0, null, new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 21, null, null, 0, null, new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 20, null, null, 0, null, new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 19, null, null, 0, null, new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 18, null, null, 0, null, new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 17, null, null, 0, null, new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 16, null, null, 0, null, new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 15, null, null, 0, null, new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 14, null, null, 0, null, new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 13, null, null, 0, null, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 12, null, null, 0, null, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 11, null, null, 0, null, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 10, null, null, 0, null, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 9, null, null, 0, null, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 8, null, null, 0, null, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 7, null, null, 0, null, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 6, null, null, 0, null, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 5, null, null, 0, null, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 4, null, null, 0, null, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 3, null, null, 0, null, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 2, null, null, 0, null, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 31, null, null, 0, null, new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 129, null, null, 0, null, new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 32, null, null, 0, null, new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 34, null, null, 0, null, new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 63, null, null, 0, null, new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 62, null, null, 0, null, new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 61, null, null, 0, null, new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 60, null, null, 0, null, new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 59, null, null, 0, null, new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 58, null, null, 0, null, new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 57, null, null, 0, null, new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 56, null, null, 0, null, new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 55, null, null, 0, null, new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 54, null, null, 0, null, new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 53, null, null, 0, null, new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 52, null, null, 0, null, new DateTime(2022, 3, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 51, null, null, 0, null, new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 50, null, null, 0, null, new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 49, null, null, 0, null, new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 48, null, null, 0, null, new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 47, null, null, 0, null, new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 46, null, null, 0, null, new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 45, null, null, 0, null, new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 44, null, null, 0, null, new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 43, null, null, 0, null, new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 42, null, null, 0, null, new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 41, null, null, 0, null, new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 40, null, null, 0, null, new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 39, null, null, 0, null, new DateTime(2022, 3, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 38, null, null, 0, null, new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 37, null, null, 0, null, new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 36, null, null, 0, null, new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 35, null, null, 0, null, new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 33, null, null, 0, null, new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "Start" },
                values: new object[] { 130, null, null, 0, null, new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
