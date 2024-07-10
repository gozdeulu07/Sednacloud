using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SednaReservationAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Star = table.Column<int>(type: "integer", nullable: false),
                    StarRating = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    RoomId = table.Column<string>(type: "text", nullable: true),
                    CheckIn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HotelId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HotelId = table.Column<string>(type: "text", nullable: true),
                    RoomTypeId = table.Column<string>(type: "text", nullable: true),
                    BasePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CreatedDate", "Deleted", "DeletedDate", "Description", "Email", "ImageUrl", "Name", "Phone", "Star", "StarRating", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("043a1ff9-91c1-4fcc-b81d-98dd822ebe50"), "4", null, false, null, "Hava olmasın", null, null, "Tahta Hotel", null, 3, 4, null },
                    { new Guid("4bddd8b8-996a-4259-a677-b1ac921ebe2d"), "2", null, false, null, "Civardaki en lüks otel", null, null, "Ateş Hotel", null, 3, 4, null },
                    { new Guid("bfec656a-1e4d-456f-8f11-8c8590331b04"), "3", null, false, null, "Civardaki en lüks otel", null, null, "Toprak Hotel", null, 3, 4, null },
                    { new Guid("caae5206-29f3-4927-972d-247a5df1a9c4"), "1", null, false, null, "Civardaki en uygun fiyatlı otel", null, null, "Su Hotel", null, 5, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedDate", "Date", "Deleted", "DeletedDate", "PaymentMethod", "ReservationId", "Status", "UpdatedDate" },
                values: new object[] { new Guid("938e7234-c1c5-456c-b42a-95cd55690989"), 7500m, new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9215), new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Utc), false, null, "Online", "asdsadasd", "Dolu", new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckIn", "CheckOut", "CreatedDate", "Deleted", "DeletedDate", "RoomId", "Status", "TotalPrice", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("28f239cf-26c1-4dab-bd42-4b3dd8778209"), new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9131), new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9137), false, null, "asdasdasdsa", "Dolu", 5000m, null, "asdasdasdsa" },
                    { new Guid("99ca61e6-3320-4600-b218-9d0a559a8ff2"), new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9148), new DateTime(2024, 8, 5, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9148), false, null, "asdasdasdsa", "Dolu", 8000m, null, "asdasdasdsa" },
                    { new Guid("dd0cd34f-a42b-4249-9668-a9b3d820023a"), new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9142), new DateTime(2024, 7, 5, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 7, 10, 6, 42, 37, 814, DateTimeKind.Utc).AddTicks(9143), false, null, "asdasdasdsa", "Dolu", 7500m, null, "asdasdasdsa" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedDate", "Deleted", "DeletedDate", "Description", "ImageUrl", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("21db6c78-1900-40c6-b52b-c1b049019a61"), null, false, null, "İki kişilik oda", null, "İki Kişilik", null },
                    { new Guid("40b78c63-8689-4bc0-a43a-961b4f5dd20d"), null, false, null, "Üç kişilik oda", null, "Üç Kişilik", null },
                    { new Guid("ef9629f3-8a81-461a-8731-bfbe8cacdf10"), null, false, null, "Tek kişilik oda", null, "Tek Kişilik", null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BasePrice", "CreatedDate", "Deleted", "DeletedDate", "HotelId", "RoomTypeId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b78fc75-d8fd-47fc-a5fc-8f3eba38ecf6"), 3500m, null, false, null, "asdasdasdsa", "asdasdasdsa", "Boş", null },
                    { new Guid("1bd11778-a1a0-4d14-8bca-2e9fac5b7759"), 3500m, null, false, null, "asdasdasdsa", "asdasdasdsa", "Boş", null },
                    { new Guid("9834a325-2a8e-44d0-9c1f-e3327fac0585"), 3500m, null, false, null, "asdasdasdsa", "asdasdasdsa", "Boş", null },
                    { new Guid("d59e3f10-d26e-4822-abec-4c06c14c542c"), 3500m, null, false, null, "asdasdasdsa", "asdasdasdsa", "Aktif", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
