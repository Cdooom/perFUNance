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
    [Migration("20170915230638_Add UserTransaction")]
    partial class AddUserTransaction
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

                    b.Property<int>("SupervisorId");

                    b.Property<int>("TotalPoints");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("perFunanceb.Model.Reward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("perFunanceb.Model.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TotalCost");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("perFunanceb.Model.TransactionReward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RewardId");

                    b.Property<int?>("TransactionId");

                    b.HasKey("Id");

                    b.HasIndex("RewardId");

                    b.HasIndex("TransactionId");

                    b.ToTable("TransactionRewards");
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

            modelBuilder.Entity("perFunanceb.Model.Transaction", b =>
                {
                    b.HasOne("perFunanceb.Model.User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("perFunanceb.Model.TransactionReward", b =>
                {
                    b.HasOne("perFunanceb.Model.Reward", "Reward")
                        .WithMany()
                        .HasForeignKey("RewardId");

                    b.HasOne("perFunanceb.Model.Transaction", "Transaction")
                        .WithMany("Rewards")
                        .HasForeignKey("TransactionId");
                });
#pragma warning restore 612, 618
        }
    }
}
