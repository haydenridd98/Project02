﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project02.Models;

namespace Project02.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    partial class AppointmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Project02.Models.Appointment", b =>
                {
                    b.Property<long>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1L,
                            Available = false,
                            Date = "Mar 22, 2022",
                            GroupSize = 0,
                            Time = "8 A.M."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}