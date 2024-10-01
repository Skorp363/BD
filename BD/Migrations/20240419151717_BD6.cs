using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class BD6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Manufacturers");

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Capacity", "CountryId", "Electric_current", "Inductance", "ManufacturerId", "MaterialId", "MaxOperating_Temp", "MinOperating_Temp", "Model", "Name", "Operating_voltage", "Part_typeId", "Power", "Price", "Resistance" },
                values: new object[,]
                {
                    { 18, 0.0, 2, 0.37, 0.01, 6, 6, 100, -20, "ec24", "Индуктивный элемент", 0.0, 2, 0.0, 15.0, 0.71999999999999997 },
                    { 19, 0.0, 3, 0.20000000000000001, 0.047, 10, 6, 100, -20, "киг", "Катушка индуктивности", 0.0, 2, 0.0, 110.0, 11.0 },
                    { 20, 0.0, 4, 0.025000000000000001, 0.01, 4, 6, 125, -40, null, "Катушка индуктивности", 0.0, 2, 0.0, 530.0, 0.0 },
                    { 21, 0.0, 1, 0.0, 0.01, 1, 6, 100, -20, "cm322522", "Индуктивность SMD", 0.0, 2, 0.0, 31.0, 2.1000000000000001 },
                    { 22, 0.0, 5, 0.10000000000000001, 30.0, 5, 6, 0, 0, "bla", "Индуктивность для подавления ЭПМ", 0.0, 2, 0.0, 49.0, 600.0 },
                    { 23, 0.0, 5, 0.29999999999999999, 36.0, 5, 6, 60, -25, "pla", "Фильтр подавления ЭПМ", 300.0, 2, 0.0, 170.0, 0.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Schedule",
                table: "Manufacturers",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Schedule",
                value: new TimeOnly(0, 0, 0));
        }
    }
}
