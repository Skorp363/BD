using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class BD5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Capacity", "CountryId", "Electric_current", "Inductance", "ManufacturerId", "MaterialId", "MaxOperating_Temp", "MinOperating_Temp", "Model", "Name", "Operating_voltage", "Part_typeId", "Power", "Price", "Resistance" },
                values: new object[,]
                {
                    { 1, 0.0, 1, 0.0, 0.0, 1, 2, 155, -55, "CF-100", "Резистор углеродистый", 500.0, 2, 1.0, 9.0, 1.0 },
                    { 2, 0.0, 1, 0.0, 0.0, 1, 2, 155, -55, "CF-100", "Резистор углеродистый", 500.0, 2, 1.0, 9.0, 100.0 },
                    { 3, 0.0, 1, 0.0, 0.0, 1, 2, 155, -55, "CF-100", "Резистор углеродистый", 500.0, 2, 1.0, 9.0, 510.0 },
                    { 4, 0.0, 1, 0.0, 0.0, 3, 2, 275, -55, "AH-100", "Резистор силовой", 1900.0, 2, 100.0, 1540.0, 0.10000000000000001 },
                    { 5, 0.0, 1, 0.0, 0.0, 3, 2, 275, -55, "AH-100", "Резистор силовой", 1900.0, 2, 100.0, 1530.0, 1.5 },
                    { 6, 0.0, 1, 0.0, 0.0, 3, 2, 275, -55, "AH-100", "Резистор силовой", 1900.0, 2, 100.0, 1540.0, 1000.0 },
                    { 7, 0.0, 1, 0.0, 0.0, 1, 1, 125, -55, "3006", "Резистор подстроечный", 1000.0, 3, 0.75, 150.0, 100.0 },
                    { 8, 0.0, 1, 0.0, 0.0, 1, 1, 150, -65, "3224", "Резистор подстроечный", 600.0, 3, 0.25, 200.0, 1000.0 },
                    { 9, 0.0, 1, 0.0, 0.0, 1, 1, 150, -65, "3266", "Резистор подстроечный", 600.0, 3, 0.25, 220.0, 50.0 },
                    { 10, 0.10000000000000001, 2, 0.0, 0.0, 2, 3, 85, -25, "JYC", "Конденсатор керамический дисковый", 2000.0, 2, 0.0, 15.0, 0.0 },
                    { 11, 2.2000000000000002, 1, 0.0, 0.0, 3, 4, 100, -40, null, "Конденсатор бумажный", 500.0, 2, 0.0, 330.0, 0.0 },
                    { 12, 0.25, 4, 0.0, 0.0, 4, 4, 60, -60, "ОМБГ-3", "Конденсатор бумажный", 400.0, 2, 0.0, 210.0, 0.0 },
                    { 13, 1.0, 2, 0.0, 0.0, 2, 5, 85, -45, "JFA", "Конденсатор металлоплёночный", 100.0, 2, 0.0, 10.0, 0.0 },
                    { 14, 180.0, 3, 0.0, 0.0, 10, 5, 125, -60, "полиэстер", "Конденсатор металлоплёночный", 63.0, 2, 0.0, 33.0, 0.0 },
                    { 15, 65000.0, 4, 0.0, 0.0, 4, 5, 65, -25, "b32320i", "Конденсатор плёночный", 350.0, 2, 0.0, 1330.0, 0.0 },
                    { 16, 0.012500000000000001, 5, 0.0, 0.0, 5, 5, 85, -25, "tzc3", "Конденсатор подстроечный", 100.0, 3, 0.0, 200.0, 0.0 },
                    { 17, 0.0022000000000000001, 2, 0.0, 0.0, 6, 3, 85, -25, "tzc3", "Конденсатор подстроечный", 100.0, 3, 0.0, 280.0, 0.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
