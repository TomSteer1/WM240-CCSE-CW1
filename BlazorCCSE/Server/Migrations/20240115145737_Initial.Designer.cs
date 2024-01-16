﻿// <auto-generated />
using System;
using BlazorCCSE.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCCSE.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240115145737_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorCCSE.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("contactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("forename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BlazorCCSE.Shared.Hotel", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("doublePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("doubleRooms")
                        .HasColumnType("int");

                    b.Property<decimal>("familyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("familyRooms")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("singlePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("singleRooms")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            id = "7ef20b5a-35c9-477e-8286-cf6f862ea3a6",
                            doublePrice = 775m,
                            doubleRooms = 20,
                            familyPrice = 950m,
                            familyRooms = 20,
                            name = "Hilton London Hotel",
                            singlePrice = 375m,
                            singleRooms = 20
                        },
                        new
                        {
                            id = "bac9bf00-9143-480e-965d-1e3c969512cc",
                            doublePrice = 500m,
                            doubleRooms = 20,
                            familyPrice = 900m,
                            familyRooms = 20,
                            name = "London Marriott Hotel",
                            singlePrice = 300m,
                            singleRooms = 20
                        },
                        new
                        {
                            id = "1dd5fbae-116e-4c85-91e4-d90c94358e95",
                            doublePrice = 120m,
                            doubleRooms = 20,
                            familyPrice = 150m,
                            familyRooms = 20,
                            name = "Travelodge Brighton Seafront",
                            singlePrice = 80m,
                            singleRooms = 20
                        },
                        new
                        {
                            id = "6111b57a-22bf-40da-be34-81d5f44bf96f",
                            doublePrice = 400m,
                            doubleRooms = 20,
                            familyPrice = 520m,
                            familyRooms = 20,
                            name = "Kings Hotel Brighton",
                            singlePrice = 180m,
                            singleRooms = 20
                        },
                        new
                        {
                            id = "c4d57d13-7969-43ed-9105-f6e85c0d5a33",
                            doublePrice = 400m,
                            doubleRooms = 20,
                            familyPrice = 520m,
                            familyRooms = 20,
                            name = "Leonardo Hotel Brighton",
                            singlePrice = 180m,
                            singleRooms = 20
                        },
                        new
                        {
                            id = "1aea2d87-c26c-4172-b1ea-d390595a5bb7",
                            doublePrice = 100m,
                            doubleRooms = 20,
                            familyPrice = 155m,
                            familyRooms = 20,
                            name = "Nevis Bank Inn, Fort William",
                            singlePrice = 90m,
                            singleRooms = 20
                        });
                });

            modelBuilder.Entity("BlazorCCSE.Shared.HotelBooking", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("depositPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotelID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("paymentid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("roomType")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("totalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("hotelID");

                    b.HasIndex("paymentid");

                    b.ToTable("HotelBookings");
                });

            modelBuilder.Entity("BlazorCCSE.Shared.PackageBooking", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("depositPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paymentid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("totalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("paymentid");

                    b.ToTable("PackageBookings");
                });

            modelBuilder.Entity("BlazorCCSE.Shared.Payment", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("bookingID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cardNumber")
                        .HasColumnType("int");

                    b.Property<int>("cvv")
                        .HasColumnType("int");

                    b.Property<int>("expiryMonth")
                        .HasColumnType("int");

                    b.Property<int>("expiryYear")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("BlazorCCSE.Shared.Tour", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("length")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spaces")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            id = "5d54c92c-7f28-4a6f-8c7b-ec52112ce1dd",
                            cost = 1200m,
                            length = 6,
                            name = "Real Britan",
                            spaces = 30
                        },
                        new
                        {
                            id = "905442b0-e3e2-4a48-9778-5ab0fe7ea690",
                            cost = 2000m,
                            length = 16,
                            name = "Britain and Ireland Explorer",
                            spaces = 40
                        },
                        new
                        {
                            id = "c4573123-4ad1-4886-bd6e-e3165de8cfb3",
                            cost = 2900m,
                            length = 12,
                            name = "Best of Britain",
                            spaces = 30
                        });
                });

            modelBuilder.Entity("BlazorCCSE.Shared.TourBooking", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("depositPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paymentid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("totalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("totalPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tourID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("paymentid");

                    b.HasIndex("tourID");

                    b.ToTable("TourBookings");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "70754ef1-8eec-45af-8364-e7306df40b35",
                            Name = "customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "8873cb9f-6a73-4de0-bdfc-6beabd6e9a04",
                            Name = "admin",
                            NormalizedName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BlazorCCSE.Shared.HotelBooking", b =>
                {
                    b.HasOne("BlazorCCSE.Shared.Hotel", "hotel")
                        .WithMany()
                        .HasForeignKey("hotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorCCSE.Shared.Payment", "payment")
                        .WithMany()
                        .HasForeignKey("paymentid");

                    b.Navigation("hotel");

                    b.Navigation("payment");
                });

            modelBuilder.Entity("BlazorCCSE.Shared.PackageBooking", b =>
                {
                    b.HasOne("BlazorCCSE.Shared.Payment", "payment")
                        .WithMany()
                        .HasForeignKey("paymentid");

                    b.Navigation("payment");
                });

            modelBuilder.Entity("BlazorCCSE.Shared.TourBooking", b =>
                {
                    b.HasOne("BlazorCCSE.Shared.Payment", "payment")
                        .WithMany()
                        .HasForeignKey("paymentid");

                    b.HasOne("BlazorCCSE.Shared.Tour", "tour")
                        .WithMany()
                        .HasForeignKey("tourID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("payment");

                    b.Navigation("tour");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BlazorCCSE.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BlazorCCSE.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorCCSE.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BlazorCCSE.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}