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
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<DateTime>(nullable: false),
                    AppointmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeSlots_Appointments_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1, null, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 784, null, new DateTime(2022, 5, 22, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 783, null, new DateTime(2022, 5, 22, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 782, null, new DateTime(2022, 5, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 781, null, new DateTime(2022, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 780, null, new DateTime(2022, 5, 21, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 779, null, new DateTime(2022, 5, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 785, null, new DateTime(2022, 5, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 778, null, new DateTime(2022, 5, 21, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 776, null, new DateTime(2022, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 775, null, new DateTime(2022, 5, 21, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 774, null, new DateTime(2022, 5, 21, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 773, null, new DateTime(2022, 5, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 772, null, new DateTime(2022, 5, 21, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 771, null, new DateTime(2022, 5, 21, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 777, null, new DateTime(2022, 5, 21, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 770, null, new DateTime(2022, 5, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 786, null, new DateTime(2022, 5, 22, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 788, null, new DateTime(2022, 5, 22, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 802, null, new DateTime(2022, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 801, null, new DateTime(2022, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 800, null, new DateTime(2022, 5, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 799, null, new DateTime(2022, 5, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 798, null, new DateTime(2022, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 797, null, new DateTime(2022, 5, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 787, null, new DateTime(2022, 5, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 796, null, new DateTime(2022, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 794, null, new DateTime(2022, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 793, null, new DateTime(2022, 5, 22, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 792, null, new DateTime(2022, 5, 22, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 791, null, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 790, null, new DateTime(2022, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 789, null, new DateTime(2022, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 795, null, new DateTime(2022, 5, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 769, null, new DateTime(2022, 5, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 768, null, new DateTime(2022, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 767, null, new DateTime(2022, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 747, null, new DateTime(2022, 5, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 746, null, new DateTime(2022, 5, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 745, null, new DateTime(2022, 5, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 744, null, new DateTime(2022, 5, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 743, null, new DateTime(2022, 5, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 742, null, new DateTime(2022, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 748, null, new DateTime(2022, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 741, null, new DateTime(2022, 5, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 739, null, new DateTime(2022, 5, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 738, null, new DateTime(2022, 5, 18, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 737, null, new DateTime(2022, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 736, null, new DateTime(2022, 5, 18, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 735, null, new DateTime(2022, 5, 18, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 734, null, new DateTime(2022, 5, 18, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 740, null, new DateTime(2022, 5, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 749, null, new DateTime(2022, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 750, null, new DateTime(2022, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 751, null, new DateTime(2022, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 766, null, new DateTime(2022, 5, 20, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 765, null, new DateTime(2022, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 764, null, new DateTime(2022, 5, 20, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 763, null, new DateTime(2022, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 762, null, new DateTime(2022, 5, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 761, null, new DateTime(2022, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 760, null, new DateTime(2022, 5, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 759, null, new DateTime(2022, 5, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 758, null, new DateTime(2022, 5, 20, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 757, null, new DateTime(2022, 5, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 756, null, new DateTime(2022, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 755, null, new DateTime(2022, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 754, null, new DateTime(2022, 5, 19, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 753, null, new DateTime(2022, 5, 19, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 752, null, new DateTime(2022, 5, 19, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 803, null, new DateTime(2022, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 733, null, new DateTime(2022, 5, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 804, null, new DateTime(2022, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 806, null, new DateTime(2022, 5, 23, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 857, null, new DateTime(2022, 5, 27, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 856, null, new DateTime(2022, 5, 27, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 855, null, new DateTime(2022, 5, 27, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 854, null, new DateTime(2022, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 853, null, new DateTime(2022, 5, 27, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 852, null, new DateTime(2022, 5, 27, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 858, null, new DateTime(2022, 5, 27, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 851, null, new DateTime(2022, 5, 27, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 849, null, new DateTime(2022, 5, 27, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 848, null, new DateTime(2022, 5, 27, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 847, null, new DateTime(2022, 5, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 846, null, new DateTime(2022, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 845, null, new DateTime(2022, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 844, null, new DateTime(2022, 5, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 850, null, new DateTime(2022, 5, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 843, null, new DateTime(2022, 5, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 859, null, new DateTime(2022, 5, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 861, null, new DateTime(2022, 5, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 875, null, new DateTime(2022, 5, 29, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 874, null, new DateTime(2022, 5, 29, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 873, null, new DateTime(2022, 5, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 872, null, new DateTime(2022, 5, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 871, null, new DateTime(2022, 5, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 870, null, new DateTime(2022, 5, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 860, null, new DateTime(2022, 5, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 869, null, new DateTime(2022, 5, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 867, null, new DateTime(2022, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 866, null, new DateTime(2022, 5, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 865, null, new DateTime(2022, 5, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 864, null, new DateTime(2022, 5, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 863, null, new DateTime(2022, 5, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 862, null, new DateTime(2022, 5, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 868, null, new DateTime(2022, 5, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 842, null, new DateTime(2022, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 841, null, new DateTime(2022, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 840, null, new DateTime(2022, 5, 26, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 820, null, new DateTime(2022, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 819, null, new DateTime(2022, 5, 24, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 818, null, new DateTime(2022, 5, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 817, null, new DateTime(2022, 5, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 816, null, new DateTime(2022, 5, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 815, null, new DateTime(2022, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 821, null, new DateTime(2022, 5, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 814, null, new DateTime(2022, 5, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 812, null, new DateTime(2022, 5, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 811, null, new DateTime(2022, 5, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 810, null, new DateTime(2022, 5, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 809, null, new DateTime(2022, 5, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 808, null, new DateTime(2022, 5, 24, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 807, null, new DateTime(2022, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 813, null, new DateTime(2022, 5, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 822, null, new DateTime(2022, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 823, null, new DateTime(2022, 5, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 824, null, new DateTime(2022, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 839, null, new DateTime(2022, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 838, null, new DateTime(2022, 5, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 837, null, new DateTime(2022, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 836, null, new DateTime(2022, 5, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 835, null, new DateTime(2022, 5, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 834, null, new DateTime(2022, 5, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 833, null, new DateTime(2022, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 832, null, new DateTime(2022, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 831, null, new DateTime(2022, 5, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 830, null, new DateTime(2022, 5, 25, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 829, null, new DateTime(2022, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 828, null, new DateTime(2022, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 827, null, new DateTime(2022, 5, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 826, null, new DateTime(2022, 5, 25, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 825, null, new DateTime(2022, 5, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 805, null, new DateTime(2022, 5, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 876, null, new DateTime(2022, 5, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 732, null, new DateTime(2022, 5, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 730, null, new DateTime(2022, 5, 18, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 638, null, new DateTime(2022, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 637, null, new DateTime(2022, 5, 10, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 636, null, new DateTime(2022, 5, 10, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 635, null, new DateTime(2022, 5, 10, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 634, null, new DateTime(2022, 5, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 633, null, new DateTime(2022, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 639, null, new DateTime(2022, 5, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 632, null, new DateTime(2022, 5, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 630, null, new DateTime(2022, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 629, null, new DateTime(2022, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 628, null, new DateTime(2022, 5, 10, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 627, null, new DateTime(2022, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 626, null, new DateTime(2022, 5, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 625, null, new DateTime(2022, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 631, null, new DateTime(2022, 5, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 624, null, new DateTime(2022, 5, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 640, null, new DateTime(2022, 5, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 642, null, new DateTime(2022, 5, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 656, null, new DateTime(2022, 5, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 655, null, new DateTime(2022, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 654, null, new DateTime(2022, 5, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 653, null, new DateTime(2022, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 652, null, new DateTime(2022, 5, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 651, null, new DateTime(2022, 5, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 641, null, new DateTime(2022, 5, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 650, null, new DateTime(2022, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 648, null, new DateTime(2022, 5, 11, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 647, null, new DateTime(2022, 5, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 646, null, new DateTime(2022, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 645, null, new DateTime(2022, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 644, null, new DateTime(2022, 5, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 643, null, new DateTime(2022, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 649, null, new DateTime(2022, 5, 11, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 623, null, new DateTime(2022, 5, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 622, null, new DateTime(2022, 5, 9, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 621, null, new DateTime(2022, 5, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 601, null, new DateTime(2022, 5, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 600, null, new DateTime(2022, 5, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 599, null, new DateTime(2022, 5, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 598, null, new DateTime(2022, 5, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 597, null, new DateTime(2022, 5, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 596, null, new DateTime(2022, 5, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 602, null, new DateTime(2022, 5, 8, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 595, null, new DateTime(2022, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 593, null, new DateTime(2022, 5, 7, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 592, null, new DateTime(2022, 5, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 591, null, new DateTime(2022, 5, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 590, null, new DateTime(2022, 5, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 589, null, new DateTime(2022, 5, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 588, null, new DateTime(2022, 5, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 594, null, new DateTime(2022, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 603, null, new DateTime(2022, 5, 8, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 604, null, new DateTime(2022, 5, 8, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 605, null, new DateTime(2022, 5, 8, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 620, null, new DateTime(2022, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 619, null, new DateTime(2022, 5, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 618, null, new DateTime(2022, 5, 9, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 617, null, new DateTime(2022, 5, 9, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 616, null, new DateTime(2022, 5, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 615, null, new DateTime(2022, 5, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 614, null, new DateTime(2022, 5, 9, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 613, null, new DateTime(2022, 5, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 612, null, new DateTime(2022, 5, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 611, null, new DateTime(2022, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 610, null, new DateTime(2022, 5, 8, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 609, null, new DateTime(2022, 5, 8, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 608, null, new DateTime(2022, 5, 8, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 607, null, new DateTime(2022, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 606, null, new DateTime(2022, 5, 8, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 657, null, new DateTime(2022, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 731, null, new DateTime(2022, 5, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 658, null, new DateTime(2022, 5, 12, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 660, null, new DateTime(2022, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 711, null, new DateTime(2022, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 710, null, new DateTime(2022, 5, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 709, null, new DateTime(2022, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 708, null, new DateTime(2022, 5, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 707, null, new DateTime(2022, 5, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 706, null, new DateTime(2022, 5, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 712, null, new DateTime(2022, 5, 16, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 705, null, new DateTime(2022, 5, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 703, null, new DateTime(2022, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 702, null, new DateTime(2022, 5, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 701, null, new DateTime(2022, 5, 15, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 700, null, new DateTime(2022, 5, 15, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 699, null, new DateTime(2022, 5, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 698, null, new DateTime(2022, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 704, null, new DateTime(2022, 5, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 697, null, new DateTime(2022, 5, 15, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 713, null, new DateTime(2022, 5, 16, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 715, null, new DateTime(2022, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 729, null, new DateTime(2022, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 728, null, new DateTime(2022, 5, 17, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 727, null, new DateTime(2022, 5, 17, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 726, null, new DateTime(2022, 5, 17, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 725, null, new DateTime(2022, 5, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 724, null, new DateTime(2022, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 714, null, new DateTime(2022, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 723, null, new DateTime(2022, 5, 17, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 721, null, new DateTime(2022, 5, 17, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 720, null, new DateTime(2022, 5, 17, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 719, null, new DateTime(2022, 5, 17, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 718, null, new DateTime(2022, 5, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 717, null, new DateTime(2022, 5, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 716, null, new DateTime(2022, 5, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 722, null, new DateTime(2022, 5, 17, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 696, null, new DateTime(2022, 5, 15, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 695, null, new DateTime(2022, 5, 15, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 694, null, new DateTime(2022, 5, 15, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 674, null, new DateTime(2022, 5, 13, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 673, null, new DateTime(2022, 5, 13, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 672, null, new DateTime(2022, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 671, null, new DateTime(2022, 5, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 670, null, new DateTime(2022, 5, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 669, null, new DateTime(2022, 5, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 675, null, new DateTime(2022, 5, 13, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 668, null, new DateTime(2022, 5, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 666, null, new DateTime(2022, 5, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 665, null, new DateTime(2022, 5, 13, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 664, null, new DateTime(2022, 5, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 663, null, new DateTime(2022, 5, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 662, null, new DateTime(2022, 5, 12, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 661, null, new DateTime(2022, 5, 12, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 667, null, new DateTime(2022, 5, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 676, null, new DateTime(2022, 5, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 677, null, new DateTime(2022, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 678, null, new DateTime(2022, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 693, null, new DateTime(2022, 5, 15, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 692, null, new DateTime(2022, 5, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 691, null, new DateTime(2022, 5, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 690, null, new DateTime(2022, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 689, null, new DateTime(2022, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 688, null, new DateTime(2022, 5, 14, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 687, null, new DateTime(2022, 5, 14, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 686, null, new DateTime(2022, 5, 14, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 685, null, new DateTime(2022, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 684, null, new DateTime(2022, 5, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 683, null, new DateTime(2022, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 682, null, new DateTime(2022, 5, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 681, null, new DateTime(2022, 5, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 680, null, new DateTime(2022, 5, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 679, null, new DateTime(2022, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 659, null, new DateTime(2022, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 877, null, new DateTime(2022, 5, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 878, null, new DateTime(2022, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 879, null, new DateTime(2022, 5, 29, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1077, null, new DateTime(2022, 6, 13, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1076, null, new DateTime(2022, 6, 13, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1075, null, new DateTime(2022, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1074, null, new DateTime(2022, 6, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1073, null, new DateTime(2022, 6, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1072, null, new DateTime(2022, 6, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1078, null, new DateTime(2022, 6, 13, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1071, null, new DateTime(2022, 6, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1069, null, new DateTime(2022, 6, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1068, null, new DateTime(2022, 6, 13, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1067, null, new DateTime(2022, 6, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1066, null, new DateTime(2022, 6, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1065, null, new DateTime(2022, 6, 12, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1064, null, new DateTime(2022, 6, 12, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1070, null, new DateTime(2022, 6, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1063, null, new DateTime(2022, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1079, null, new DateTime(2022, 6, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1081, null, new DateTime(2022, 6, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1095, null, new DateTime(2022, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1094, null, new DateTime(2022, 6, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1093, null, new DateTime(2022, 6, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1092, null, new DateTime(2022, 6, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1091, null, new DateTime(2022, 6, 14, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1090, null, new DateTime(2022, 6, 14, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1080, null, new DateTime(2022, 6, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1089, null, new DateTime(2022, 6, 14, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1087, null, new DateTime(2022, 6, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1086, null, new DateTime(2022, 6, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1085, null, new DateTime(2022, 6, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1084, null, new DateTime(2022, 6, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1083, null, new DateTime(2022, 6, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1082, null, new DateTime(2022, 6, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1088, null, new DateTime(2022, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1062, null, new DateTime(2022, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1061, null, new DateTime(2022, 6, 12, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1060, null, new DateTime(2022, 6, 12, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1040, null, new DateTime(2022, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1039, null, new DateTime(2022, 6, 10, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1038, null, new DateTime(2022, 6, 10, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1037, null, new DateTime(2022, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1036, null, new DateTime(2022, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1035, null, new DateTime(2022, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1041, null, new DateTime(2022, 6, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1034, null, new DateTime(2022, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1032, null, new DateTime(2022, 6, 10, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1031, null, new DateTime(2022, 6, 10, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1030, null, new DateTime(2022, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1029, null, new DateTime(2022, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1028, null, new DateTime(2022, 6, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1027, null, new DateTime(2022, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1033, null, new DateTime(2022, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1042, null, new DateTime(2022, 6, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1043, null, new DateTime(2022, 6, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1044, null, new DateTime(2022, 6, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1059, null, new DateTime(2022, 6, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1058, null, new DateTime(2022, 6, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1057, null, new DateTime(2022, 6, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1056, null, new DateTime(2022, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1055, null, new DateTime(2022, 6, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1054, null, new DateTime(2022, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1053, null, new DateTime(2022, 6, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1052, null, new DateTime(2022, 6, 11, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1051, null, new DateTime(2022, 6, 11, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1050, null, new DateTime(2022, 6, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1049, null, new DateTime(2022, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1048, null, new DateTime(2022, 6, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1047, null, new DateTime(2022, 6, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1046, null, new DateTime(2022, 6, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1045, null, new DateTime(2022, 6, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1096, null, new DateTime(2022, 6, 15, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1026, null, new DateTime(2022, 6, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1097, null, new DateTime(2022, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1099, null, new DateTime(2022, 6, 15, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1150, null, new DateTime(2022, 6, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1149, null, new DateTime(2022, 6, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1148, null, new DateTime(2022, 6, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1147, null, new DateTime(2022, 6, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1146, null, new DateTime(2022, 6, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1145, null, new DateTime(2022, 6, 19, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1151, null, new DateTime(2022, 6, 19, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1144, null, new DateTime(2022, 6, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1142, null, new DateTime(2022, 6, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1141, null, new DateTime(2022, 6, 18, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1140, null, new DateTime(2022, 6, 18, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1139, null, new DateTime(2022, 6, 18, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1138, null, new DateTime(2022, 6, 18, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1137, null, new DateTime(2022, 6, 18, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1143, null, new DateTime(2022, 6, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1136, null, new DateTime(2022, 6, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1152, null, new DateTime(2022, 6, 19, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1154, null, new DateTime(2022, 6, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1168, null, new DateTime(2022, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1167, null, new DateTime(2022, 6, 20, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1166, null, new DateTime(2022, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1165, null, new DateTime(2022, 6, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1164, null, new DateTime(2022, 6, 20, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1163, null, new DateTime(2022, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1153, null, new DateTime(2022, 6, 19, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1162, null, new DateTime(2022, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1160, null, new DateTime(2022, 6, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1159, null, new DateTime(2022, 6, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1158, null, new DateTime(2022, 6, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1157, null, new DateTime(2022, 6, 19, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1156, null, new DateTime(2022, 6, 19, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1155, null, new DateTime(2022, 6, 19, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1161, null, new DateTime(2022, 6, 20, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1135, null, new DateTime(2022, 6, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1134, null, new DateTime(2022, 6, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1133, null, new DateTime(2022, 6, 18, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1113, null, new DateTime(2022, 6, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1112, null, new DateTime(2022, 6, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1111, null, new DateTime(2022, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1110, null, new DateTime(2022, 6, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1109, null, new DateTime(2022, 6, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1108, null, new DateTime(2022, 6, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1114, null, new DateTime(2022, 6, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1107, null, new DateTime(2022, 6, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1105, null, new DateTime(2022, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1104, null, new DateTime(2022, 6, 15, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1103, null, new DateTime(2022, 6, 15, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1102, null, new DateTime(2022, 6, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1101, null, new DateTime(2022, 6, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1100, null, new DateTime(2022, 6, 15, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1106, null, new DateTime(2022, 6, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1115, null, new DateTime(2022, 6, 16, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1116, null, new DateTime(2022, 6, 16, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1117, null, new DateTime(2022, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1132, null, new DateTime(2022, 6, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1131, null, new DateTime(2022, 6, 17, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1130, null, new DateTime(2022, 6, 17, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1129, null, new DateTime(2022, 6, 17, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1128, null, new DateTime(2022, 6, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1127, null, new DateTime(2022, 6, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1126, null, new DateTime(2022, 6, 17, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1125, null, new DateTime(2022, 6, 17, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1124, null, new DateTime(2022, 6, 17, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1123, null, new DateTime(2022, 6, 17, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1122, null, new DateTime(2022, 6, 17, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1121, null, new DateTime(2022, 6, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1120, null, new DateTime(2022, 6, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1119, null, new DateTime(2022, 6, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1118, null, new DateTime(2022, 6, 16, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1098, null, new DateTime(2022, 6, 15, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1025, null, new DateTime(2022, 6, 9, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1024, null, new DateTime(2022, 6, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1023, null, new DateTime(2022, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 930, null, new DateTime(2022, 6, 2, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 929, null, new DateTime(2022, 6, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 928, null, new DateTime(2022, 6, 2, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 927, null, new DateTime(2022, 6, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 926, null, new DateTime(2022, 6, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 925, null, new DateTime(2022, 6, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 931, null, new DateTime(2022, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 924, null, new DateTime(2022, 6, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 922, null, new DateTime(2022, 6, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 921, null, new DateTime(2022, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 920, null, new DateTime(2022, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 919, null, new DateTime(2022, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 918, null, new DateTime(2022, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 917, null, new DateTime(2022, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 923, null, new DateTime(2022, 6, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 916, null, new DateTime(2022, 6, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 932, null, new DateTime(2022, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 934, null, new DateTime(2022, 6, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 948, null, new DateTime(2022, 6, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 947, null, new DateTime(2022, 6, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 946, null, new DateTime(2022, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 945, null, new DateTime(2022, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 944, null, new DateTime(2022, 6, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 943, null, new DateTime(2022, 6, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 933, null, new DateTime(2022, 6, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 942, null, new DateTime(2022, 6, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 940, null, new DateTime(2022, 6, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 939, null, new DateTime(2022, 6, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 938, null, new DateTime(2022, 6, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 937, null, new DateTime(2022, 6, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 936, null, new DateTime(2022, 6, 2, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 935, null, new DateTime(2022, 6, 2, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 941, null, new DateTime(2022, 6, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 915, null, new DateTime(2022, 6, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 914, null, new DateTime(2022, 6, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 913, null, new DateTime(2022, 6, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 893, null, new DateTime(2022, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 892, null, new DateTime(2022, 5, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 891, null, new DateTime(2022, 5, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 890, null, new DateTime(2022, 5, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 889, null, new DateTime(2022, 5, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 888, null, new DateTime(2022, 5, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 894, null, new DateTime(2022, 5, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 887, null, new DateTime(2022, 5, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 885, null, new DateTime(2022, 5, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 884, null, new DateTime(2022, 5, 29, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 883, null, new DateTime(2022, 5, 29, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 882, null, new DateTime(2022, 5, 29, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 881, null, new DateTime(2022, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 880, null, new DateTime(2022, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 886, null, new DateTime(2022, 5, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 895, null, new DateTime(2022, 5, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 896, null, new DateTime(2022, 5, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 897, null, new DateTime(2022, 5, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 912, null, new DateTime(2022, 6, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 911, null, new DateTime(2022, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 910, null, new DateTime(2022, 5, 31, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 909, null, new DateTime(2022, 5, 31, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 908, null, new DateTime(2022, 5, 31, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 907, null, new DateTime(2022, 5, 31, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 906, null, new DateTime(2022, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 905, null, new DateTime(2022, 5, 31, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 904, null, new DateTime(2022, 5, 31, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 903, null, new DateTime(2022, 5, 31, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 902, null, new DateTime(2022, 5, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 901, null, new DateTime(2022, 5, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 900, null, new DateTime(2022, 5, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 899, null, new DateTime(2022, 5, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 898, null, new DateTime(2022, 5, 31, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 949, null, new DateTime(2022, 6, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 950, null, new DateTime(2022, 6, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 951, null, new DateTime(2022, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 952, null, new DateTime(2022, 6, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1003, null, new DateTime(2022, 6, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1002, null, new DateTime(2022, 6, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1001, null, new DateTime(2022, 6, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1000, null, new DateTime(2022, 6, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 999, null, new DateTime(2022, 6, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 998, null, new DateTime(2022, 6, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1004, null, new DateTime(2022, 6, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 997, null, new DateTime(2022, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 995, null, new DateTime(2022, 6, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 994, null, new DateTime(2022, 6, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 993, null, new DateTime(2022, 6, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 992, null, new DateTime(2022, 6, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 991, null, new DateTime(2022, 6, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 990, null, new DateTime(2022, 6, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 996, null, new DateTime(2022, 6, 7, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1005, null, new DateTime(2022, 6, 8, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1006, null, new DateTime(2022, 6, 8, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1007, null, new DateTime(2022, 6, 8, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1022, null, new DateTime(2022, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1021, null, new DateTime(2022, 6, 9, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1020, null, new DateTime(2022, 6, 9, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1019, null, new DateTime(2022, 6, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1018, null, new DateTime(2022, 6, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1017, null, new DateTime(2022, 6, 9, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1016, null, new DateTime(2022, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1015, null, new DateTime(2022, 6, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1014, null, new DateTime(2022, 6, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1013, null, new DateTime(2022, 6, 8, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1012, null, new DateTime(2022, 6, 8, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1011, null, new DateTime(2022, 6, 8, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1010, null, new DateTime(2022, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1009, null, new DateTime(2022, 6, 8, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1008, null, new DateTime(2022, 6, 8, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 989, null, new DateTime(2022, 6, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 587, null, new DateTime(2022, 5, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 988, null, new DateTime(2022, 6, 6, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 986, null, new DateTime(2022, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 966, null, new DateTime(2022, 6, 5, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 965, null, new DateTime(2022, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 964, null, new DateTime(2022, 6, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 963, null, new DateTime(2022, 6, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 962, null, new DateTime(2022, 6, 4, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 961, null, new DateTime(2022, 6, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 967, null, new DateTime(2022, 6, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 960, null, new DateTime(2022, 6, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 958, null, new DateTime(2022, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 957, null, new DateTime(2022, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 956, null, new DateTime(2022, 6, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 955, null, new DateTime(2022, 6, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 954, null, new DateTime(2022, 6, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 953, null, new DateTime(2022, 6, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 959, null, new DateTime(2022, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 968, null, new DateTime(2022, 6, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 969, null, new DateTime(2022, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 970, null, new DateTime(2022, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 985, null, new DateTime(2022, 6, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 984, null, new DateTime(2022, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 983, null, new DateTime(2022, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 982, null, new DateTime(2022, 6, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 981, null, new DateTime(2022, 6, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 980, null, new DateTime(2022, 6, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 979, null, new DateTime(2022, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 978, null, new DateTime(2022, 6, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 977, null, new DateTime(2022, 6, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 976, null, new DateTime(2022, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 975, null, new DateTime(2022, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 974, null, new DateTime(2022, 6, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 973, null, new DateTime(2022, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 972, null, new DateTime(2022, 6, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 971, null, new DateTime(2022, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 987, null, new DateTime(2022, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 586, null, new DateTime(2022, 5, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 585, null, new DateTime(2022, 5, 6, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 584, null, new DateTime(2022, 5, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 199, null, new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 198, null, new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 197, null, new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 196, null, new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 195, null, new DateTime(2022, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 194, null, new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 200, null, new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 193, null, new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 191, null, new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 190, null, new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 189, null, new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 188, null, new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 187, null, new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 186, null, new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 192, null, new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 185, null, new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 201, null, new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 203, null, new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 217, null, new DateTime(2022, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 216, null, new DateTime(2022, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 215, null, new DateTime(2022, 4, 8, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 214, null, new DateTime(2022, 4, 8, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 213, null, new DateTime(2022, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 212, null, new DateTime(2022, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 202, null, new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 211, null, new DateTime(2022, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 209, null, new DateTime(2022, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 208, null, new DateTime(2022, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 207, null, new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 206, null, new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 205, null, new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 204, null, new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 210, null, new DateTime(2022, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 184, null, new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 183, null, new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 182, null, new DateTime(2022, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 162, null, new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 161, null, new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 160, null, new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 159, null, new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 158, null, new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 157, null, new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 163, null, new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 156, null, new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 154, null, new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 153, null, new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 152, null, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 151, null, new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 150, null, new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 149, null, new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 155, null, new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 164, null, new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 165, null, new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 166, null, new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 181, null, new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 180, null, new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 179, null, new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 178, null, new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 177, null, new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 176, null, new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 175, null, new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 174, null, new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 173, null, new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 172, null, new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 171, null, new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 170, null, new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 169, null, new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 168, null, new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 167, null, new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 218, null, new DateTime(2022, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 148, null, new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 219, null, new DateTime(2022, 4, 8, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 221, null, new DateTime(2022, 4, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 272, null, new DateTime(2022, 4, 12, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 271, null, new DateTime(2022, 4, 12, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 270, null, new DateTime(2022, 4, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 269, null, new DateTime(2022, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 268, null, new DateTime(2022, 4, 12, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 267, null, new DateTime(2022, 4, 12, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 273, null, new DateTime(2022, 4, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 266, null, new DateTime(2022, 4, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 264, null, new DateTime(2022, 4, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 263, null, new DateTime(2022, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 262, null, new DateTime(2022, 4, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 261, null, new DateTime(2022, 4, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 260, null, new DateTime(2022, 4, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 259, null, new DateTime(2022, 4, 11, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 265, null, new DateTime(2022, 4, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 258, null, new DateTime(2022, 4, 11, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 274, null, new DateTime(2022, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 276, null, new DateTime(2022, 4, 13, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 290, null, new DateTime(2022, 4, 14, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 289, null, new DateTime(2022, 4, 14, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 288, null, new DateTime(2022, 4, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 287, null, new DateTime(2022, 4, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 286, null, new DateTime(2022, 4, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 285, null, new DateTime(2022, 4, 13, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 275, null, new DateTime(2022, 4, 13, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 284, null, new DateTime(2022, 4, 13, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 282, null, new DateTime(2022, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 281, null, new DateTime(2022, 4, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 280, null, new DateTime(2022, 4, 13, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 279, null, new DateTime(2022, 4, 13, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 278, null, new DateTime(2022, 4, 13, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 277, null, new DateTime(2022, 4, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 283, null, new DateTime(2022, 4, 13, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 257, null, new DateTime(2022, 4, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 256, null, new DateTime(2022, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 255, null, new DateTime(2022, 4, 11, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 235, null, new DateTime(2022, 4, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 234, null, new DateTime(2022, 4, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 233, null, new DateTime(2022, 4, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 232, null, new DateTime(2022, 4, 9, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 231, null, new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 230, null, new DateTime(2022, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 236, null, new DateTime(2022, 4, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 229, null, new DateTime(2022, 4, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 227, null, new DateTime(2022, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 226, null, new DateTime(2022, 4, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 225, null, new DateTime(2022, 4, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 224, null, new DateTime(2022, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 223, null, new DateTime(2022, 4, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 222, null, new DateTime(2022, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 228, null, new DateTime(2022, 4, 9, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 237, null, new DateTime(2022, 4, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 238, null, new DateTime(2022, 4, 10, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 239, null, new DateTime(2022, 4, 10, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 254, null, new DateTime(2022, 4, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 253, null, new DateTime(2022, 4, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 252, null, new DateTime(2022, 4, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 251, null, new DateTime(2022, 4, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 250, null, new DateTime(2022, 4, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 249, null, new DateTime(2022, 4, 11, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 248, null, new DateTime(2022, 4, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 247, null, new DateTime(2022, 4, 10, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 246, null, new DateTime(2022, 4, 10, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 245, null, new DateTime(2022, 4, 10, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 244, null, new DateTime(2022, 4, 10, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 243, null, new DateTime(2022, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 242, null, new DateTime(2022, 4, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 241, null, new DateTime(2022, 4, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 240, null, new DateTime(2022, 4, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 220, null, new DateTime(2022, 4, 8, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 147, null, new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 146, null, new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 145, null, new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 52, null, new DateTime(2022, 3, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 51, null, new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 50, null, new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 49, null, new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 48, null, new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 47, null, new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 53, null, new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 46, null, new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 44, null, new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 43, null, new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 42, null, new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 41, null, new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 40, null, new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 39, null, new DateTime(2022, 3, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 45, null, new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 38, null, new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 54, null, new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 56, null, new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 70, null, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 69, null, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 68, null, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 67, null, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 66, null, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 65, null, new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 55, null, new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 64, null, new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 62, null, new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 61, null, new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 60, null, new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 59, null, new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 58, null, new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 57, null, new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 63, null, new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 37, null, new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 36, null, new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 35, null, new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 15, null, new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 14, null, new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 13, null, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 12, null, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 11, null, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 10, null, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 16, null, new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 9, null, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 7, null, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 6, null, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 5, null, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 4, null, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 3, null, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 2, null, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 8, null, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 17, null, new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 18, null, new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 19, null, new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 34, null, new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 33, null, new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 32, null, new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 31, null, new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 30, null, new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 29, null, new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 28, null, new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 27, null, new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 26, null, new DateTime(2022, 3, 24, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 25, null, new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 24, null, new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 23, null, new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 22, null, new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 21, null, new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 20, null, new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 71, null, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 72, null, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 73, null, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 74, null, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 125, null, new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 124, null, new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 123, null, new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 122, null, new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 121, null, new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 120, null, new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 126, null, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 119, null, new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 117, null, new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 116, null, new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 115, null, new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 114, null, new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 113, null, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 112, null, new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 118, null, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 127, null, new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 128, null, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 129, null, new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 144, null, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 143, null, new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 142, null, new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 141, null, new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 140, null, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 139, null, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 138, null, new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 137, null, new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 136, null, new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 135, null, new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 134, null, new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 133, null, new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 132, null, new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 131, null, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 130, null, new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 111, null, new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 291, null, new DateTime(2022, 4, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 110, null, new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 108, null, new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 88, null, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 87, null, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 86, null, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 85, null, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 84, null, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 83, null, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 89, null, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 82, null, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 80, null, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 79, null, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 78, null, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 77, null, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 76, null, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 75, null, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 81, null, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 90, null, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 91, null, new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 92, null, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 107, null, new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 106, null, new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 105, null, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 104, null, new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 103, null, new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 102, null, new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 101, null, new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 100, null, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 99, null, new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 98, null, new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 97, null, new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 96, null, new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 95, null, new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 94, null, new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 93, null, new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 109, null, new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1169, null, new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 292, null, new DateTime(2022, 4, 14, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 294, null, new DateTime(2022, 4, 14, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 492, null, new DateTime(2022, 4, 29, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 491, null, new DateTime(2022, 4, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 490, null, new DateTime(2022, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 489, null, new DateTime(2022, 4, 29, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 488, null, new DateTime(2022, 4, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 487, null, new DateTime(2022, 4, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 493, null, new DateTime(2022, 4, 29, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 486, null, new DateTime(2022, 4, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 484, null, new DateTime(2022, 4, 29, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 483, null, new DateTime(2022, 4, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 482, null, new DateTime(2022, 4, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 481, null, new DateTime(2022, 4, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 480, null, new DateTime(2022, 4, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 479, null, new DateTime(2022, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 485, null, new DateTime(2022, 4, 29, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 478, null, new DateTime(2022, 4, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 494, null, new DateTime(2022, 4, 29, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 496, null, new DateTime(2022, 4, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 510, null, new DateTime(2022, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 509, null, new DateTime(2022, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 508, null, new DateTime(2022, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 507, null, new DateTime(2022, 4, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 506, null, new DateTime(2022, 4, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 505, null, new DateTime(2022, 4, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 495, null, new DateTime(2022, 4, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 504, null, new DateTime(2022, 4, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 502, null, new DateTime(2022, 4, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 501, null, new DateTime(2022, 4, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 500, null, new DateTime(2022, 4, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 499, null, new DateTime(2022, 4, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 498, null, new DateTime(2022, 4, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 497, null, new DateTime(2022, 4, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 503, null, new DateTime(2022, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 477, null, new DateTime(2022, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 476, null, new DateTime(2022, 4, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 475, null, new DateTime(2022, 4, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 455, null, new DateTime(2022, 4, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 454, null, new DateTime(2022, 4, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 453, null, new DateTime(2022, 4, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 452, null, new DateTime(2022, 4, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 451, null, new DateTime(2022, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 450, null, new DateTime(2022, 4, 26, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 456, null, new DateTime(2022, 4, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 449, null, new DateTime(2022, 4, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 447, null, new DateTime(2022, 4, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 446, null, new DateTime(2022, 4, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 445, null, new DateTime(2022, 4, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 444, null, new DateTime(2022, 4, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 443, null, new DateTime(2022, 4, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 442, null, new DateTime(2022, 4, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 448, null, new DateTime(2022, 4, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 457, null, new DateTime(2022, 4, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 458, null, new DateTime(2022, 4, 27, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 459, null, new DateTime(2022, 4, 27, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 474, null, new DateTime(2022, 4, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 473, null, new DateTime(2022, 4, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 472, null, new DateTime(2022, 4, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 471, null, new DateTime(2022, 4, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 470, null, new DateTime(2022, 4, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 469, null, new DateTime(2022, 4, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 468, null, new DateTime(2022, 4, 27, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 467, null, new DateTime(2022, 4, 27, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 466, null, new DateTime(2022, 4, 27, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 465, null, new DateTime(2022, 4, 27, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 464, null, new DateTime(2022, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 463, null, new DateTime(2022, 4, 27, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 462, null, new DateTime(2022, 4, 27, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 461, null, new DateTime(2022, 4, 27, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 460, null, new DateTime(2022, 4, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 511, null, new DateTime(2022, 5, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 441, null, new DateTime(2022, 4, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 512, null, new DateTime(2022, 5, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 514, null, new DateTime(2022, 5, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 565, null, new DateTime(2022, 5, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 564, null, new DateTime(2022, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 563, null, new DateTime(2022, 5, 5, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 562, null, new DateTime(2022, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 561, null, new DateTime(2022, 5, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 560, null, new DateTime(2022, 5, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 566, null, new DateTime(2022, 5, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 559, null, new DateTime(2022, 5, 4, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 557, null, new DateTime(2022, 5, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 556, null, new DateTime(2022, 5, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 555, null, new DateTime(2022, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 554, null, new DateTime(2022, 5, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 553, null, new DateTime(2022, 5, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 552, null, new DateTime(2022, 5, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 558, null, new DateTime(2022, 5, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 551, null, new DateTime(2022, 5, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 567, null, new DateTime(2022, 5, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 569, null, new DateTime(2022, 5, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 583, null, new DateTime(2022, 5, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 582, null, new DateTime(2022, 5, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 581, null, new DateTime(2022, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 580, null, new DateTime(2022, 5, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 579, null, new DateTime(2022, 5, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 578, null, new DateTime(2022, 5, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 568, null, new DateTime(2022, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 577, null, new DateTime(2022, 5, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 575, null, new DateTime(2022, 5, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 574, null, new DateTime(2022, 5, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 573, null, new DateTime(2022, 5, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 572, null, new DateTime(2022, 5, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 571, null, new DateTime(2022, 5, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 570, null, new DateTime(2022, 5, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 576, null, new DateTime(2022, 5, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 550, null, new DateTime(2022, 5, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 549, null, new DateTime(2022, 5, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 548, null, new DateTime(2022, 5, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 528, null, new DateTime(2022, 5, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 527, null, new DateTime(2022, 5, 2, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 526, null, new DateTime(2022, 5, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 525, null, new DateTime(2022, 5, 2, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 524, null, new DateTime(2022, 5, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 523, null, new DateTime(2022, 5, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 529, null, new DateTime(2022, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 522, null, new DateTime(2022, 5, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 520, null, new DateTime(2022, 5, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 519, null, new DateTime(2022, 5, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 518, null, new DateTime(2022, 5, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 517, null, new DateTime(2022, 5, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 516, null, new DateTime(2022, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 515, null, new DateTime(2022, 5, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 521, null, new DateTime(2022, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 530, null, new DateTime(2022, 5, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 531, null, new DateTime(2022, 5, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 532, null, new DateTime(2022, 5, 2, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 547, null, new DateTime(2022, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 546, null, new DateTime(2022, 5, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 545, null, new DateTime(2022, 5, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 544, null, new DateTime(2022, 5, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 543, null, new DateTime(2022, 5, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 542, null, new DateTime(2022, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 541, null, new DateTime(2022, 5, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 540, null, new DateTime(2022, 5, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 539, null, new DateTime(2022, 5, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 538, null, new DateTime(2022, 5, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 537, null, new DateTime(2022, 5, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 536, null, new DateTime(2022, 5, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 535, null, new DateTime(2022, 5, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 534, null, new DateTime(2022, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 533, null, new DateTime(2022, 5, 2, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 513, null, new DateTime(2022, 5, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 440, null, new DateTime(2022, 4, 25, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 439, null, new DateTime(2022, 4, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 438, null, new DateTime(2022, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 345, null, new DateTime(2022, 4, 18, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 344, null, new DateTime(2022, 4, 18, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 343, null, new DateTime(2022, 4, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 342, null, new DateTime(2022, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 341, null, new DateTime(2022, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 340, null, new DateTime(2022, 4, 18, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 346, null, new DateTime(2022, 4, 18, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 339, null, new DateTime(2022, 4, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 337, null, new DateTime(2022, 4, 17, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 336, null, new DateTime(2022, 4, 17, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 335, null, new DateTime(2022, 4, 17, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 334, null, new DateTime(2022, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 333, null, new DateTime(2022, 4, 17, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 332, null, new DateTime(2022, 4, 17, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 338, null, new DateTime(2022, 4, 17, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 331, null, new DateTime(2022, 4, 17, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 347, null, new DateTime(2022, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 349, null, new DateTime(2022, 4, 18, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 363, null, new DateTime(2022, 4, 19, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 362, null, new DateTime(2022, 4, 19, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 361, null, new DateTime(2022, 4, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 360, null, new DateTime(2022, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 359, null, new DateTime(2022, 4, 19, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 358, null, new DateTime(2022, 4, 19, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 348, null, new DateTime(2022, 4, 18, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 357, null, new DateTime(2022, 4, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 355, null, new DateTime(2022, 4, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 354, null, new DateTime(2022, 4, 19, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 353, null, new DateTime(2022, 4, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 352, null, new DateTime(2022, 4, 19, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 351, null, new DateTime(2022, 4, 18, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 350, null, new DateTime(2022, 4, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 356, null, new DateTime(2022, 4, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 330, null, new DateTime(2022, 4, 17, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 329, null, new DateTime(2022, 4, 17, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 328, null, new DateTime(2022, 4, 17, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 308, null, new DateTime(2022, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 307, null, new DateTime(2022, 4, 15, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 306, null, new DateTime(2022, 4, 15, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 305, null, new DateTime(2022, 4, 15, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 304, null, new DateTime(2022, 4, 15, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 303, null, new DateTime(2022, 4, 15, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 309, null, new DateTime(2022, 4, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 302, null, new DateTime(2022, 4, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 300, null, new DateTime(2022, 4, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 299, null, new DateTime(2022, 4, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 298, null, new DateTime(2022, 4, 14, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 297, null, new DateTime(2022, 4, 14, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 296, null, new DateTime(2022, 4, 14, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 295, null, new DateTime(2022, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 301, null, new DateTime(2022, 4, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 310, null, new DateTime(2022, 4, 15, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 311, null, new DateTime(2022, 4, 15, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 312, null, new DateTime(2022, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 327, null, new DateTime(2022, 4, 17, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 326, null, new DateTime(2022, 4, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 325, null, new DateTime(2022, 4, 16, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 324, null, new DateTime(2022, 4, 16, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 323, null, new DateTime(2022, 4, 16, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 322, null, new DateTime(2022, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 321, null, new DateTime(2022, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 320, null, new DateTime(2022, 4, 16, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 319, null, new DateTime(2022, 4, 16, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 318, null, new DateTime(2022, 4, 16, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 317, null, new DateTime(2022, 4, 16, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 316, null, new DateTime(2022, 4, 16, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 315, null, new DateTime(2022, 4, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 314, null, new DateTime(2022, 4, 16, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 313, null, new DateTime(2022, 4, 16, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 364, null, new DateTime(2022, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 365, null, new DateTime(2022, 4, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 366, null, new DateTime(2022, 4, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 367, null, new DateTime(2022, 4, 20, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 418, null, new DateTime(2022, 4, 24, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 417, null, new DateTime(2022, 4, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 416, null, new DateTime(2022, 4, 23, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 415, null, new DateTime(2022, 4, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 414, null, new DateTime(2022, 4, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 413, null, new DateTime(2022, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 419, null, new DateTime(2022, 4, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 412, null, new DateTime(2022, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 410, null, new DateTime(2022, 4, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 409, null, new DateTime(2022, 4, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 408, null, new DateTime(2022, 4, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 407, null, new DateTime(2022, 4, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 406, null, new DateTime(2022, 4, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 405, null, new DateTime(2022, 4, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 411, null, new DateTime(2022, 4, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 420, null, new DateTime(2022, 4, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 421, null, new DateTime(2022, 4, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 422, null, new DateTime(2022, 4, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 437, null, new DateTime(2022, 4, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 436, null, new DateTime(2022, 4, 25, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 435, null, new DateTime(2022, 4, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 434, null, new DateTime(2022, 4, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 433, null, new DateTime(2022, 4, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 432, null, new DateTime(2022, 4, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 431, null, new DateTime(2022, 4, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 430, null, new DateTime(2022, 4, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 429, null, new DateTime(2022, 4, 24, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 428, null, new DateTime(2022, 4, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 427, null, new DateTime(2022, 4, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 426, null, new DateTime(2022, 4, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 425, null, new DateTime(2022, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 424, null, new DateTime(2022, 4, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 423, null, new DateTime(2022, 4, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 404, null, new DateTime(2022, 4, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 293, null, new DateTime(2022, 4, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 403, null, new DateTime(2022, 4, 22, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 401, null, new DateTime(2022, 4, 22, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 381, null, new DateTime(2022, 4, 21, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 380, null, new DateTime(2022, 4, 21, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 379, null, new DateTime(2022, 4, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 378, null, new DateTime(2022, 4, 21, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 377, null, new DateTime(2022, 4, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 376, null, new DateTime(2022, 4, 20, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 382, null, new DateTime(2022, 4, 21, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 375, null, new DateTime(2022, 4, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 373, null, new DateTime(2022, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 372, null, new DateTime(2022, 4, 20, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 371, null, new DateTime(2022, 4, 20, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 370, null, new DateTime(2022, 4, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 369, null, new DateTime(2022, 4, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 368, null, new DateTime(2022, 4, 20, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 374, null, new DateTime(2022, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 383, null, new DateTime(2022, 4, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 384, null, new DateTime(2022, 4, 21, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 385, null, new DateTime(2022, 4, 21, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 400, null, new DateTime(2022, 4, 22, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 399, null, new DateTime(2022, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 398, null, new DateTime(2022, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 397, null, new DateTime(2022, 4, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 396, null, new DateTime(2022, 4, 22, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 395, null, new DateTime(2022, 4, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 394, null, new DateTime(2022, 4, 22, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 393, null, new DateTime(2022, 4, 22, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 392, null, new DateTime(2022, 4, 22, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 391, null, new DateTime(2022, 4, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 390, null, new DateTime(2022, 4, 21, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 389, null, new DateTime(2022, 4, 21, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 388, null, new DateTime(2022, 4, 21, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 387, null, new DateTime(2022, 4, 21, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 386, null, new DateTime(2022, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 402, null, new DateTime(2022, 4, 22, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "Start" },
                values: new object[] { 1170, null, new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_AppointmentID",
                table: "TimeSlots",
                column: "AppointmentID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
