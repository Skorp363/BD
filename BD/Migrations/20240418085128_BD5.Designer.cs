﻿// <auto-generated />
using System;
using BD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BD.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240418085128_BD5")]
    partial class BD5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BD.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "TW",
                            Name = "Тайвань"
                        },
                        new
                        {
                            Id = 2,
                            Code = "CN",
                            Name = "Китай"
                        },
                        new
                        {
                            Id = 3,
                            Code = "RU",
                            Name = "Россия"
                        },
                        new
                        {
                            Id = 4,
                            Code = "DE",
                            Name = "Германия"
                        },
                        new
                        {
                            Id = 5,
                            Code = "JP",
                            Name = "Япония"
                        },
                        new
                        {
                            Id = 6,
                            Code = "US",
                            Name = "США"
                        },
                        new
                        {
                            Id = 7,
                            Code = "CH",
                            Name = "Швейцария"
                        });
                });

            modelBuilder.Entity("BD.Models.Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Capacity")
                        .HasColumnType("double precision");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<double>("Electric_current")
                        .HasColumnType("double precision");

                    b.Property<double>("Inductance")
                        .HasColumnType("double precision");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("integer");

                    b.Property<int>("MaterialId")
                        .HasColumnType("integer");

                    b.Property<int>("MaxOperating_Temp")
                        .HasColumnType("integer");

                    b.Property<int>("MinOperating_Temp")
                        .HasColumnType("integer");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Operating_voltage")
                        .HasColumnType("double precision");

                    b.Property<int>("Part_typeId")
                        .HasColumnType("integer");

                    b.Property<double>("Power")
                        .HasColumnType("double precision");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("Resistance")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("Part_typeId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 1,
                            MaterialId = 2,
                            MaxOperating_Temp = 155,
                            MinOperating_Temp = -55,
                            Model = "CF-100",
                            Name = "Резистор углеродистый",
                            Operating_voltage = 500.0,
                            Part_typeId = 2,
                            Power = 1.0,
                            Price = 9.0,
                            Resistance = 1.0
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 1,
                            MaterialId = 2,
                            MaxOperating_Temp = 155,
                            MinOperating_Temp = -55,
                            Model = "CF-100",
                            Name = "Резистор углеродистый",
                            Operating_voltage = 500.0,
                            Part_typeId = 2,
                            Power = 1.0,
                            Price = 9.0,
                            Resistance = 100.0
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 1,
                            MaterialId = 2,
                            MaxOperating_Temp = 155,
                            MinOperating_Temp = -55,
                            Model = "CF-100",
                            Name = "Резистор углеродистый",
                            Operating_voltage = 500.0,
                            Part_typeId = 2,
                            Power = 1.0,
                            Price = 9.0,
                            Resistance = 510.0
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 3,
                            MaterialId = 2,
                            MaxOperating_Temp = 275,
                            MinOperating_Temp = -55,
                            Model = "AH-100",
                            Name = "Резистор силовой",
                            Operating_voltage = 1900.0,
                            Part_typeId = 2,
                            Power = 100.0,
                            Price = 1540.0,
                            Resistance = 0.10000000000000001
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 3,
                            MaterialId = 2,
                            MaxOperating_Temp = 275,
                            MinOperating_Temp = -55,
                            Model = "AH-100",
                            Name = "Резистор силовой",
                            Operating_voltage = 1900.0,
                            Part_typeId = 2,
                            Power = 100.0,
                            Price = 1530.0,
                            Resistance = 1.5
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 3,
                            MaterialId = 2,
                            MaxOperating_Temp = 275,
                            MinOperating_Temp = -55,
                            Model = "AH-100",
                            Name = "Резистор силовой",
                            Operating_voltage = 1900.0,
                            Part_typeId = 2,
                            Power = 100.0,
                            Price = 1540.0,
                            Resistance = 1000.0
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 1,
                            MaterialId = 1,
                            MaxOperating_Temp = 125,
                            MinOperating_Temp = -55,
                            Model = "3006",
                            Name = "Резистор подстроечный",
                            Operating_voltage = 1000.0,
                            Part_typeId = 3,
                            Power = 0.75,
                            Price = 150.0,
                            Resistance = 100.0
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 1,
                            MaterialId = 1,
                            MaxOperating_Temp = 150,
                            MinOperating_Temp = -65,
                            Model = "3224",
                            Name = "Резистор подстроечный",
                            Operating_voltage = 600.0,
                            Part_typeId = 3,
                            Power = 0.25,
                            Price = 200.0,
                            Resistance = 1000.0
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 0.0,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 1,
                            MaterialId = 1,
                            MaxOperating_Temp = 150,
                            MinOperating_Temp = -65,
                            Model = "3266",
                            Name = "Резистор подстроечный",
                            Operating_voltage = 600.0,
                            Part_typeId = 3,
                            Power = 0.25,
                            Price = 220.0,
                            Resistance = 50.0
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 0.10000000000000001,
                            CountryId = 2,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 2,
                            MaterialId = 3,
                            MaxOperating_Temp = 85,
                            MinOperating_Temp = -25,
                            Model = "JYC",
                            Name = "Конденсатор керамический дисковый",
                            Operating_voltage = 2000.0,
                            Part_typeId = 2,
                            Power = 0.0,
                            Price = 15.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 2.2000000000000002,
                            CountryId = 1,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 3,
                            MaterialId = 4,
                            MaxOperating_Temp = 100,
                            MinOperating_Temp = -40,
                            Name = "Конденсатор бумажный",
                            Operating_voltage = 500.0,
                            Part_typeId = 2,
                            Power = 0.0,
                            Price = 330.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 0.25,
                            CountryId = 4,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 4,
                            MaterialId = 4,
                            MaxOperating_Temp = 60,
                            MinOperating_Temp = -60,
                            Model = "ОМБГ-3",
                            Name = "Конденсатор бумажный",
                            Operating_voltage = 400.0,
                            Part_typeId = 2,
                            Power = 0.0,
                            Price = 210.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 1.0,
                            CountryId = 2,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 2,
                            MaterialId = 5,
                            MaxOperating_Temp = 85,
                            MinOperating_Temp = -45,
                            Model = "JFA",
                            Name = "Конденсатор металлоплёночный",
                            Operating_voltage = 100.0,
                            Part_typeId = 2,
                            Power = 0.0,
                            Price = 10.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 180.0,
                            CountryId = 3,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 10,
                            MaterialId = 5,
                            MaxOperating_Temp = 125,
                            MinOperating_Temp = -60,
                            Model = "полиэстер",
                            Name = "Конденсатор металлоплёночный",
                            Operating_voltage = 63.0,
                            Part_typeId = 2,
                            Power = 0.0,
                            Price = 33.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 65000.0,
                            CountryId = 4,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 4,
                            MaterialId = 5,
                            MaxOperating_Temp = 65,
                            MinOperating_Temp = -25,
                            Model = "b32320i",
                            Name = "Конденсатор плёночный",
                            Operating_voltage = 350.0,
                            Part_typeId = 2,
                            Power = 0.0,
                            Price = 1330.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 0.012500000000000001,
                            CountryId = 5,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 5,
                            MaterialId = 5,
                            MaxOperating_Temp = 85,
                            MinOperating_Temp = -25,
                            Model = "tzc3",
                            Name = "Конденсатор подстроечный",
                            Operating_voltage = 100.0,
                            Part_typeId = 3,
                            Power = 0.0,
                            Price = 200.0,
                            Resistance = 0.0
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 0.0022000000000000001,
                            CountryId = 2,
                            Electric_current = 0.0,
                            Inductance = 0.0,
                            ManufacturerId = 6,
                            MaterialId = 3,
                            MaxOperating_Temp = 85,
                            MinOperating_Temp = -25,
                            Model = "tzc3",
                            Name = "Конденсатор подстроечный",
                            Operating_voltage = 100.0,
                            Part_typeId = 3,
                            Power = 0.0,
                            Price = 280.0,
                            Resistance = 0.0
                        });
                });

            modelBuilder.Entity("BD.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Activity")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Director")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<TimeOnly>("Schedule")
                        .HasColumnType("time without time zone");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activity = "Electronics",
                            Address = "Риверсайд, Калифорния",
                            Country = "США",
                            Director = "Гордон Борнс",
                            Name = "BOURNS",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Activity = "Electronics",
                            Address = "г. Хэфей, провинция Аньхой, КНР; г. Дунгуан, провинция Гуаньдун.",
                            Country = "Китай",
                            Name = "JB Capacitors",
                            Phone = "+8-522-790-50-91",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Activity = "Electronics",
                            Address = "Форт-Лодердейл, Флорида",
                            Country = "США",
                            Name = "Kemet Electronics",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Activity = "Electronics",
                            Address = "Мюнхен",
                            Country = "Германия",
                            Name = "EPCOS",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Activity = "Electronics",
                            Address = "Нагаокакё, Киото",
                            Country = "Япония",
                            Director = "Норио Накадзима",
                            Name = "Murata Electronics",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Activity = "Electronics",
                            Address = " Финикс, Аризона",
                            Country = "США",
                            Director = "Хассан Эль-Хури",
                            Name = "ON Semiconductor",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            Activity = "Electronics",
                            Address = "Женева",
                            Country = "Швейцария",
                            Director = "Жан-Марк Чери, Remi El-Ouazzane",
                            Name = "STMicroelectronics",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            Activity = "Semiconductor",
                            Address = "Уилмингтон, Массачусетс",
                            Country = "США",
                            Director = "Венсан Рош",
                            Name = "Analog Devices",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Activity = "Electronics",
                            Address = "4F-1, № 288-7, ShinYa Road, район Чиен Чен, Гаосюн, 80673",
                            Country = "Тайвань",
                            Name = "Song Huei Electronic",
                            Phone = "+8-867-815-00-38",
                            Schedule = new TimeOnly(0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Activity = "Electronics",
                            Address = "431110, Республика Мордовия, п. Зубова Поляна, ул. Новикова-Прибоя, 35.",
                            Country = "Россия",
                            Director = "Казеев Александр Александрович",
                            Name = "ОАО \"Радиодеталь\"",
                            Phone = "+7-834-582-11-50",
                            Schedule = new TimeOnly(0, 0, 0)
                        });
                });

            modelBuilder.Entity("BD.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 1,
                            Name = "Металлокерамика"
                        },
                        new
                        {
                            Id = 2,
                            Code = 2,
                            Name = "Углерод"
                        },
                        new
                        {
                            Id = 3,
                            Code = 3,
                            Name = "Керамика"
                        },
                        new
                        {
                            Id = 4,
                            Code = 4,
                            Name = "Бумага"
                        },
                        new
                        {
                            Id = 5,
                            Code = 5,
                            Name = "Плёнка"
                        },
                        new
                        {
                            Id = 6,
                            Code = 6,
                            Name = "Медь"
                        },
                        new
                        {
                            Id = 7,
                            Code = 7,
                            Name = "Феррит"
                        },
                        new
                        {
                            Id = 8,
                            Code = 8,
                            Name = "Кварц"
                        },
                        new
                        {
                            Id = 9,
                            Code = 9,
                            Name = "Полипропилен"
                        },
                        new
                        {
                            Id = 10,
                            Code = 10,
                            Name = "Стекло"
                        });
                });

            modelBuilder.Entity("BD.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 1,
                            Name = "Активный"
                        },
                        new
                        {
                            Id = 2,
                            Code = 2,
                            Name = "Пассивный"
                        },
                        new
                        {
                            Id = 3,
                            Code = 3,
                            Name = "Подстроечный"
                        });
                });

            modelBuilder.Entity("BD.Models.Details", b =>
                {
                    b.HasOne("BD.Models.Country", "Country")
                        .WithMany("Details")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD.Models.Manufacturer", "Manufacturer")
                        .WithMany("Details")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD.Models.Material", "Material")
                        .WithMany("Details")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BD.Models.Type", "Part_type")
                        .WithMany("Details")
                        .HasForeignKey("Part_typeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Manufacturer");

                    b.Navigation("Material");

                    b.Navigation("Part_type");
                });

            modelBuilder.Entity("BD.Models.Country", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("BD.Models.Manufacturer", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("BD.Models.Material", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("BD.Models.Type", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}