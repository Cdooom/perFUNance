﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using perFunanceb.Models;
using System;

namespace perFunanceb.Migrations
{
    [DbContext(typeof(perFunancebContext))]
    [Migration("20170914000325_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("perFunanceb.Model.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SupervisorIdId");

                    b.Property<int>("TotalPoints");

                    b.Property<int?>("UserId1");

                    b.Property<int?>("UserIdId");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorIdId");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserIdId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("perFunanceb.Model.Reward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int?>("TransactionId");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("perFunanceb.Model.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TotalCost");

                    b.Property<int?>("UserIdId");

                    b.HasKey("Id");

                    b.HasIndex("UserIdId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("perFunanceb.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsSuperVisor");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PassWord");

                    b.Property<string>("Position");

                    b.Property<string>("SocialSecurity");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("perFunanceb.Model.Review", b =>
                {
                    b.HasOne("perFunanceb.Model.User", "SupervisorId")
                        .WithMany()
                        .HasForeignKey("SupervisorIdId");

                    b.HasOne("perFunanceb.Model.User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId1");

                    b.HasOne("perFunanceb.Model.User", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdId");
                });

            modelBuilder.Entity("perFunanceb.Model.Reward", b =>
                {
                    b.HasOne("perFunanceb.Model.Transaction")
                        .WithMany("Rewards")
                        .HasForeignKey("TransactionId");
                });

            modelBuilder.Entity("perFunanceb.Model.Transaction", b =>
                {
                    b.HasOne("perFunanceb.Model.User", "UserId")
                        .WithMany("Transactions")
                        .HasForeignKey("UserIdId");
                });
#pragma warning restore 612, 618
        }
    }
}
