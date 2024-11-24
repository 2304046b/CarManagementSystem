using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(4122), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(4128), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5522), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5526), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5532), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5844), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5847), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5852), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5855), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5857), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 11, 20, 12, 34, 52, 907, DateTimeKind.Local).AddTicks(5861), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
