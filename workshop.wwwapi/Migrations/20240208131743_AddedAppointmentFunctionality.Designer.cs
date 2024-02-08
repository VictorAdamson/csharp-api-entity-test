﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240208131743_AddedAppointmentFunctionality")]
    partial class AddedAppointmentFunctionality
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("booking");

                    b.HasKey("PatientId", "DoctorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            DoctorId = 1,
                            Booking = new DateTime(2024, 2, 8, 13, 17, 43, 637, DateTimeKind.Utc).AddTicks(1380)
                        },
                        new
                        {
                            PatientId = 5,
                            DoctorId = 2,
                            Booking = new DateTime(2024, 2, 8, 13, 17, 43, 637, DateTimeKind.Utc).AddTicks(1380)
                        },
                        new
                        {
                            PatientId = 4,
                            DoctorId = 3,
                            Booking = new DateTime(2024, 2, 8, 13, 17, 43, 637, DateTimeKind.Utc).AddTicks(1380)
                        },
                        new
                        {
                            PatientId = 2,
                            DoctorId = 1,
                            Booking = new DateTime(2024, 2, 9, 13, 17, 43, 637, DateTimeKind.Utc).AddTicks(1459)
                        },
                        new
                        {
                            PatientId = 4,
                            DoctorId = 2,
                            Booking = new DateTime(2024, 2, 9, 13, 17, 43, 637, DateTimeKind.Utc).AddTicks(1459)
                        },
                        new
                        {
                            PatientId = 3,
                            DoctorId = 3,
                            Booking = new DateTime(2024, 2, 9, 13, 17, 43, 637, DateTimeKind.Utc).AddTicks(1459)
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Old Beardo"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Dr Strangelove"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Krieger"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Victor Adamson"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Name Namesson"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "John Smith"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Person MacPersonface"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Phill Collins"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}