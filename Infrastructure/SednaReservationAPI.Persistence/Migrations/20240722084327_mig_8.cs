using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SednaReservationAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Deleted", "DeletedDate", "Description", "Email", "ImageUrl", "Name", "Phone", "Star", "StarRating", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1cb9359d-1893-4f65-814d-6024b9f7e398"), "Address B", null, null, false, null, "Description B", "hotelB@example.com", "imageB.jpg", "Hotel B", "0987654321", 0, 4f, null },
                    { new Guid("2850c561-ca0e-4d68-b1c9-af3905b6973e"), "Address B", null, null, false, null, "Description E", "hotelE@example.com", "imageB.jpg", "Hotel E", "0987654321", 0, 1.5f, null },
                    { new Guid("68e9996c-dbbb-4077-ae81-ec3bfc49e951"), "Address B", null, null, false, null, "Description C", "hotelC@example.com", "imageB.jpg", "Hotel C", "0987654321", 0, 4.2f, null },
                    { new Guid("8b1fb143-362d-4b6c-86b6-8bafe91a2171"), "Address A", null, null, false, null, "Description A", "hotelA@example.com", "imageA.jpg", "Hotel A", "1234567890", 0, 5f, null },
                    { new Guid("a9d44dc8-609e-49fc-9ba5-b397da2c71ac"), "Address B", null, null, false, null, "Description D", "hotelD@example.com", "imageB.jpg", "Hotel D", "0987654321", 0, 3.7f, null },
                    { new Guid("b2bcaa32-c9a2-4f30-a8be-2e16bda6360a"), "Address B", null, null, false, null, "Description G", "hotelG@example.com", "imageB.jpg", "Hotel G", "0987654321", 0, 4.8f, null },
                    { new Guid("fd603fa8-3e29-4113-a089-ccbf40c4eefe"), "Address B", null, null, false, null, "Description F", "hotelF@example.com", "imageB.jpg", "Hotel F", "0987654321", 0, 3.9f, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("1cb9359d-1893-4f65-814d-6024b9f7e398"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("2850c561-ca0e-4d68-b1c9-af3905b6973e"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("68e9996c-dbbb-4077-ae81-ec3bfc49e951"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("8b1fb143-362d-4b6c-86b6-8bafe91a2171"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("a9d44dc8-609e-49fc-9ba5-b397da2c71ac"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b2bcaa32-c9a2-4f30-a8be-2e16bda6360a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("fd603fa8-3e29-4113-a089-ccbf40c4eefe"));
        }
    }
}
