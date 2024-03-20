using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketShop.EventCatalog.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Sports" },
                    { 2, "Concerts" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "Date", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Beyonce", 2, new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9754), "Beyonce in concert", 300m },
                    { 2, "GNR", 2, new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9769), "Guns N Roses Tour", 500m },
                    { 3, "ATLUS", 2, new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9771), "Persona Live Concert", 400m },
                    { 4, "MonolithSoft", 2, new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9773), "Xenoblade Orchestra", 500m },
                    { 5, "None", 1, new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9775), "AC Milan vs Inter FC", 700m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
