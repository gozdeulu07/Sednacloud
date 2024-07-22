using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SednaReservationAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Deleted", "DeletedDate", "Description", "Email", "ImageUrl", "Name", "Phone", "Star", "StarRating", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("174334b2-fe3a-4d94-aae6-2d8096fec568"), "Address B", null, null, false, null, "Description F", "hotelF@example.com", "imageB.jpg", "Hotel F", "0987654321", 1, 3.9f, null },
                    { new Guid("18a6f42e-55e5-46d0-a5bf-5ecf9303f030"), "Address A", null, null, false, null, "Description A", "hotelA@example.com", "imageA.jpg", "Hotel A", "1234567890", 3, 5f, null },
                    { new Guid("659fb1a0-7790-47f2-931b-429864582a8e"), "Address B", null, null, false, null, "Description G", "hotelG@example.com", "imageB.jpg", "Hotel G", "0987654321", 5, 4.8f, null },
                    { new Guid("72bc2179-eb9b-4573-9c7d-42228e0ba0b5"), "Address B", null, null, false, null, "Description E", "hotelE@example.com", "imageB.jpg", "Hotel E", "0987654321", 4, 1.5f, null },
                    { new Guid("95d65214-5ed4-46cd-b571-216cffaa0e87"), "Address B", null, null, false, null, "Description C", "hotelC@example.com", "imageB.jpg", "Hotel C", "0987654321", 5, 4.2f, null },
                    { new Guid("c95524cc-e624-4a5a-9731-478f45df7968"), "Address B", null, null, false, null, "Description D", "hotelD@example.com", "imageB.jpg", "Hotel D", "0987654321", 2, 3.7f, null },
                    { new Guid("e1a0c3d2-b0fb-444b-aa82-7b0ae50ea89a"), "Address B", null, null, false, null, "Description B", "hotelB@example.com", "imageB.jpg", "Hotel B", "0987654321", 5, 4f, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("174334b2-fe3a-4d94-aae6-2d8096fec568"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("18a6f42e-55e5-46d0-a5bf-5ecf9303f030"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("659fb1a0-7790-47f2-931b-429864582a8e"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("72bc2179-eb9b-4573-9c7d-42228e0ba0b5"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("95d65214-5ed4-46cd-b571-216cffaa0e87"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c95524cc-e624-4a5a-9731-478f45df7968"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("e1a0c3d2-b0fb-444b-aa82-7b0ae50ea89a"));

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
    }
}
