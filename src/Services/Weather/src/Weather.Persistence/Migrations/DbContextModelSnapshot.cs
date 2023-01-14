﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weather.Persistence;

#nullable disable

namespace Weather.Persistence.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Weather.Domain.Forecasts.Forecast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Summary")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TemperatureC")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Forecasts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fa06f8db-ca63-4922-8e00-18b18d2089ea"),
                            Date = new DateTime(2023, 1, 15, 13, 34, 6, 705, DateTimeKind.Local).AddTicks(1678),
                            Summary = "Hot",
                            TemperatureC = 49
                        },
                        new
                        {
                            Id = new Guid("1ea6663f-419d-4950-97c9-8fb635fc2e41"),
                            Date = new DateTime(2023, 1, 16, 13, 34, 6, 705, DateTimeKind.Local).AddTicks(1784),
                            Summary = "Cool",
                            TemperatureC = 47
                        },
                        new
                        {
                            Id = new Guid("d54e2ca2-3187-4e31-a46d-5d9b8b94cf54"),
                            Date = new DateTime(2023, 1, 17, 13, 34, 6, 705, DateTimeKind.Local).AddTicks(1789),
                            Summary = "Chilly",
                            TemperatureC = -14
                        },
                        new
                        {
                            Id = new Guid("2b95893a-071a-4a49-b26d-4f6dacfa0bf3"),
                            Date = new DateTime(2023, 1, 18, 13, 34, 6, 705, DateTimeKind.Local).AddTicks(1794),
                            Summary = "Chilly",
                            TemperatureC = 38
                        },
                        new
                        {
                            Id = new Guid("74d254ab-f943-43a1-b07f-7565b966fed8"),
                            Date = new DateTime(2023, 1, 19, 13, 34, 6, 705, DateTimeKind.Local).AddTicks(1798),
                            Summary = "Chilly",
                            TemperatureC = 49
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
