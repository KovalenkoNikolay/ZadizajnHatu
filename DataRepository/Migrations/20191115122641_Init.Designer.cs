﻿// <auto-generated />
using System;
using DataRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataRepository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191115122641_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DataRepository.DbEntities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RegionId");

                    b.HasKey("CityId");

                    b.HasIndex("RegionId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Киев",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Белая Церковь",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Бровары",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 4,
                            Name = "Борисполь",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 5,
                            Name = "Фастов",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 6,
                            Name = "Ирпень",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 7,
                            Name = "Вишнёвое",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 8,
                            Name = "Васильков",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 9,
                            Name = "Боярка",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 10,
                            Name = "Обухов",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 11,
                            Name = "Буча",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 12,
                            Name = "Переяслав",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 13,
                            Name = "Вышгород",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 14,
                            Name = "Славутич",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 15,
                            Name = "Яготин",
                            RegionId = 1
                        },
                        new
                        {
                            CityId = 16,
                            Name = "Винница",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 17,
                            Name = "Жмеринка",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 18,
                            Name = "Могилёв-Подольский",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 19,
                            Name = "Хмельник",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 20,
                            Name = "Гайсин",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 21,
                            Name = "Козятин",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 22,
                            Name = "Ладижин",
                            RegionId = 2
                        },
                        new
                        {
                            CityId = 23,
                            Name = "Калиновка",
                            RegionId = 2
                        });
                });

            modelBuilder.Entity("DataRepository.DbEntities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Украина"
                        });
                });

            modelBuilder.Entity("DataRepository.DbEntities.Image", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<Guid?>("PortfolioProjectId");

                    b.HasKey("ImageId");

                    b.HasIndex("PortfolioProjectId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("DataRepository.DbEntities.PortfolioProject", b =>
                {
                    b.Property<Guid>("PortfolioProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<Guid>("WorkerId");

                    b.HasKey("PortfolioProjectId");

                    b.HasIndex("WorkerId");

                    b.ToTable("PortfolioProjects");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("RegionId");

                    b.HasIndex("CountryId");

                    b.ToTable("Region");

                    b.HasData(
                        new
                        {
                            RegionId = 1,
                            CountryId = 1,
                            Name = "Киевская"
                        },
                        new
                        {
                            RegionId = 2,
                            CountryId = 1,
                            Name = "Винницкая"
                        },
                        new
                        {
                            RegionId = 3,
                            CountryId = 1,
                            Name = "Волынская"
                        },
                        new
                        {
                            RegionId = 4,
                            CountryId = 1,
                            Name = "Днепропетровская"
                        },
                        new
                        {
                            RegionId = 5,
                            CountryId = 1,
                            Name = "Донецкая"
                        },
                        new
                        {
                            RegionId = 6,
                            CountryId = 1,
                            Name = "Житомирская"
                        },
                        new
                        {
                            RegionId = 7,
                            CountryId = 1,
                            Name = "Закарпатская"
                        },
                        new
                        {
                            RegionId = 8,
                            CountryId = 1,
                            Name = "Ивано-Франковская"
                        },
                        new
                        {
                            RegionId = 9,
                            CountryId = 1,
                            Name = "Кировоградская"
                        },
                        new
                        {
                            RegionId = 10,
                            CountryId = 1,
                            Name = "Луганская"
                        },
                        new
                        {
                            RegionId = 11,
                            CountryId = 1,
                            Name = "Львовская"
                        },
                        new
                        {
                            RegionId = 12,
                            CountryId = 1,
                            Name = "Николаевская"
                        },
                        new
                        {
                            RegionId = 13,
                            CountryId = 1,
                            Name = "Одесская"
                        },
                        new
                        {
                            RegionId = 14,
                            CountryId = 1,
                            Name = "Полтавская"
                        },
                        new
                        {
                            RegionId = 15,
                            CountryId = 1,
                            Name = "Ровненская"
                        },
                        new
                        {
                            RegionId = 16,
                            CountryId = 1,
                            Name = "Сумская"
                        },
                        new
                        {
                            RegionId = 17,
                            CountryId = 1,
                            Name = "Тернопольская"
                        },
                        new
                        {
                            RegionId = 18,
                            CountryId = 1,
                            Name = "Харьковская"
                        },
                        new
                        {
                            RegionId = 19,
                            CountryId = 1,
                            Name = "Херсонская"
                        },
                        new
                        {
                            RegionId = 20,
                            CountryId = 1,
                            Name = "Хмельницкая"
                        },
                        new
                        {
                            RegionId = 21,
                            CountryId = 1,
                            Name = "Черкасская"
                        },
                        new
                        {
                            RegionId = 22,
                            CountryId = 1,
                            Name = "Черниговская"
                        },
                        new
                        {
                            RegionId = 23,
                            CountryId = 1,
                            Name = "Черновицкая"
                        });
                });

            modelBuilder.Entity("DataRepository.DbEntities.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("WorkerTypeId");

                    b.HasKey("ServiceId");

                    b.HasIndex("WorkerTypeId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkGeography", b =>
                {
                    b.Property<Guid>("WorkGeographyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CityId");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("RegionId");

                    b.Property<Guid?>("WorkerId");

                    b.HasKey("WorkGeographyId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("RegionId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkGeography");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Worker", b =>
                {
                    b.Property<Guid>("WorkerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("ContactInfo");

                    b.Property<string>("Name");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<bool>("RemoteWork");

                    b.Property<int>("WorkerTypeId");

                    b.HasKey("WorkerId");

                    b.HasIndex("WorkerTypeId");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            WorkerId = new Guid("e84c3e1b-a590-4e89-95a4-75c0e9cc951f"),
                            ContactInfo = "{\"address\":\"Ломоносова 50\",\"email\":\"verandadesignstuio@gmail.com\",\"phones\":[\"+1111111111\",\"222222222222\"],\"site\":\"verandadesignstuion.com\",\"socialMedia\":{\"instagram\":\"instagramVeranda\",\"facebook\":\"facebookVeranda\",\"pinterest\":\"pinterestVeranda\"}}",
                            Name = "Veranda Design Studio",
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RemoteWork = false,
                            WorkerTypeId = 1
                        });
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerCity", b =>
                {
                    b.Property<Guid>("WorkerCityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<Guid>("WorkerId");

                    b.HasKey("WorkerCityId");

                    b.HasIndex("CityId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerCity");
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerPrice", b =>
                {
                    b.Property<Guid>("WorkerPriceId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("WorkerId");

                    b.HasKey("WorkerPriceId");

                    b.HasIndex("WorkerId")
                        .IsUnique();

                    b.ToTable("WorkerPrice");

                    b.HasData(
                        new
                        {
                            WorkerPriceId = new Guid("0e94650f-b0f9-4dc1-9e2e-4c4e5cca147b"),
                            Amount = 10m,
                            WorkerId = new Guid("e84c3e1b-a590-4e89-95a4-75c0e9cc951f")
                        });
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Rating");

                    b.Property<Guid>("WorkerId");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerReviews");
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerService", b =>
                {
                    b.Property<Guid>("WorkerServiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ServiceId");

                    b.Property<Guid>("WorkerId");

                    b.HasKey("WorkerServiceId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerService");
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerType", b =>
                {
                    b.Property<int>("WorkerTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("WorkerTypeId");

                    b.ToTable("WorkerType");

                    b.HasData(
                        new
                        {
                            WorkerTypeId = 1,
                            Name = "Дизайнер"
                        },
                        new
                        {
                            WorkerTypeId = 2,
                            Name = "Чертежник"
                        },
                        new
                        {
                            WorkerTypeId = 3,
                            Name = "Архитектор"
                        });
                });

            modelBuilder.Entity("DataRepository.DbEntities.City", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.Image", b =>
                {
                    b.HasOne("DataRepository.DbEntities.PortfolioProject", "PortfolioProject")
                        .WithMany("Images")
                        .HasForeignKey("PortfolioProjectId");
                });

            modelBuilder.Entity("DataRepository.DbEntities.PortfolioProject", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Worker", "Worker")
                        .WithMany("PortfolioProjects")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.Region", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.Service", b =>
                {
                    b.HasOne("DataRepository.DbEntities.WorkerType", "WorkerType")
                        .WithMany("Services")
                        .HasForeignKey("WorkerTypeId");
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkGeography", b =>
                {
                    b.HasOne("DataRepository.DbEntities.City", "City")
                        .WithMany("WorkGeographies")
                        .HasForeignKey("CityId");

                    b.HasOne("DataRepository.DbEntities.Country", "Country")
                        .WithMany("WorkGeographies")
                        .HasForeignKey("CountryId");

                    b.HasOne("DataRepository.DbEntities.Region", "Region")
                        .WithMany("WorkGeographies")
                        .HasForeignKey("RegionId");

                    b.HasOne("DataRepository.DbEntities.Worker", "Worker")
                        .WithMany("WorkGeographies")
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Worker", b =>
                {
                    b.HasOne("DataRepository.DbEntities.WorkerType", "WorkerType")
                        .WithMany()
                        .HasForeignKey("WorkerTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerCity", b =>
                {
                    b.HasOne("DataRepository.DbEntities.City", "City")
                        .WithMany("WorkerCities")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataRepository.DbEntities.Worker", "Worker")
                        .WithMany("WorkerCities")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerPrice", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Worker", "Worker")
                        .WithOne("WorkerPrice")
                        .HasForeignKey("DataRepository.DbEntities.WorkerPrice", "WorkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerReview", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Worker", "Worker")
                        .WithMany("WorkerReviews")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataRepository.DbEntities.WorkerService", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Service", "Service")
                        .WithMany("WorkerServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataRepository.DbEntities.Worker", "Worker")
                        .WithMany("WorkerServices")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}