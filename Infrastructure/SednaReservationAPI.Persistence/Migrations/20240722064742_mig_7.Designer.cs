﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SednaReservationAPI.Persistence.Contexts;

#nullable disable

namespace SednaReservationAPI.Persistence.Migrations
{
    [DbContext(typeof(SednaReservationAPIDbContext))]
<<<<<<<< Updated upstream:Infrastructure/SednaReservationAPI.Persistence/Migrations/20240716061749_mig_1.Designer.cs
    [Migration("20240716061749_mig_1")]
    partial class mig_1
========
    [Migration("20240722064742_mig_7")]
    partial class mig_7
>>>>>>>> Stashed changes:Infrastructure/SednaReservationAPI.Persistence/Migrations/20240722064742_mig_7.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HotelRoom", b =>
                {
                    b.Property<Guid>("HotelsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uuid");

                    b.HasKey("HotelsId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("HotelRoom");
                });

            modelBuilder.Entity("HotelRoomType", b =>
                {
                    b.Property<Guid>("HotelsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomTypesId")
                        .HasColumnType("uuid");

                    b.HasKey("HotelsId", "RoomTypesId");

                    b.HasIndex("RoomTypesId");

                    b.ToTable("HotelRoomType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ReservationRoom", b =>
                {
                    b.Property<Guid>("ReservationsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uuid");

                    b.HasKey("ReservationsId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("ReservationRoom");
                });

            modelBuilder.Entity("ReservationRoomType", b =>
                {
                    b.Property<Guid>("ReservationsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomTypesId")
                        .HasColumnType("uuid");

                    b.HasKey("ReservationsId", "RoomTypesId");

                    b.HasIndex("RoomTypesId");

                    b.ToTable("ReservationRoomType");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<float>("Star")
                        .HasColumnType("real");

                    b.Property<int>("StarRating")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RefreshTokenExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("text");

                    b.Property<int>("ReservationId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HotelId")
                        .HasColumnType("text");

                    b.Property<Guid?>("HotelId1")
                        .HasColumnType("uuid");

                    b.Property<string>("RoomId")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HotelId1");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uuid");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RoomTypeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("AdultPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("BaseAdultPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("BaseChildPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("ChildPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("RoomTypeId1")
                        .HasColumnType("uuid");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId1");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.RoomType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("HotelRoom", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Hotel", null)
                        .WithMany()
                        .HasForeignKey("HotelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SednaReservationAPI.Domain.Entities.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelRoomType", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Hotel", null)
                        .WithMany()
                        .HasForeignKey("HotelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SednaReservationAPI.Domain.Entities.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SednaReservationAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReservationRoom", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SednaReservationAPI.Domain.Entities.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReservationRoomType", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SednaReservationAPI.Domain.Entities.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Customer", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Room", null)
                        .WithMany("Customers")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Hotel", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Customer", null)
                        .WithMany("Hotels")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Payment", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Customer", null)
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Customer", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("SednaReservationAPI.Domain.Entities.Hotel", null)
                        .WithMany("Reservations")
                        .HasForeignKey("HotelId1");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Review", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.Customer", null)
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId");

                    b.HasOne("SednaReservationAPI.Domain.Entities.Hotel", null)
                        .WithMany("Reviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SednaReservationAPI.Domain.Entities.Room", null)
                        .WithMany("Reviews")
                        .HasForeignKey("RoomId");

                    b.HasOne("SednaReservationAPI.Domain.Entities.RoomType", null)
                        .WithMany("Reviews")
                        .HasForeignKey("RoomTypeId");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Room", b =>
                {
                    b.HasOne("SednaReservationAPI.Domain.Entities.RoomType", null)
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId1");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Hotels");

                    b.Navigation("Payments");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Hotel", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.Room", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("SednaReservationAPI.Domain.Entities.RoomType", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
