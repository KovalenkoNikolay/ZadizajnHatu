﻿// <auto-generated />
using System;
using DataRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataRepository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181009202514_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataRepository.DbEntities.Tasks.Task", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<int?>("TaskStatusId");

                    b.Property<Guid?>("WorkId");

                    b.HasKey("TaskId");

                    b.HasIndex("ClientId");

                    b.HasIndex("TaskStatusId");

                    b.HasIndex("WorkId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Tasks.TaskStatus", b =>
                {
                    b.Property<int>("TaskStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskStatusName");

                    b.HasKey("TaskStatusId");

                    b.ToTable("TaskStatus");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Users.Client", b =>
                {
                    b.Property<Guid>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("UserId");

                    b.HasKey("ClientId");

                    b.HasIndex("UserId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Users.Designer", b =>
                {
                    b.Property<Guid>("DesignerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactInfo");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<Guid?>("UserId");

                    b.HasKey("DesignerId");

                    b.HasIndex("UserId");

                    b.ToTable("Designers");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Users.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginName");

                    b.Property<string>("PhoneNumber");

                    b.Property<DateTime>("RegisteredDate");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Works.Work", b =>
                {
                    b.Property<Guid>("WorkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currency");

                    b.Property<Guid?>("DesignerId");

                    b.Property<decimal>("MaxCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WorkTypeId");

                    b.HasKey("WorkId");

                    b.HasIndex("DesignerId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Works.WorkType", b =>
                {
                    b.Property<int>("WorkTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WorkTypeName");

                    b.HasKey("WorkTypeId");

                    b.ToTable("WorkType");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Tasks.Task", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Users.Client", "Client")
                        .WithMany("Tasks")
                        .HasForeignKey("ClientId");

                    b.HasOne("DataRepository.DbEntities.Tasks.TaskStatus", "TaskStatus")
                        .WithMany()
                        .HasForeignKey("TaskStatusId");

                    b.HasOne("DataRepository.DbEntities.Works.Work", "Work")
                        .WithMany()
                        .HasForeignKey("WorkId");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Users.Client", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Users.Designer", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DataRepository.DbEntities.Works.Work", b =>
                {
                    b.HasOne("DataRepository.DbEntities.Users.Designer")
                        .WithMany("Works")
                        .HasForeignKey("DesignerId");

                    b.HasOne("DataRepository.DbEntities.Works.WorkType", "WorkType")
                        .WithMany()
                        .HasForeignKey("WorkTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
