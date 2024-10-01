using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class BD7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Types",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Materials",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufacturers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Details",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Countries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Capacity", "CountryId", "Electric_current", "Inductance", "ManufacturerId", "MaterialId", "MaxOperating_Temp", "MinOperating_Temp", "Model", "Name", "Operating_voltage", "Part_typeId", "Power", "Price", "Resistance" },
                values: new object[,]
                {
                    { 24, 0.0, 4, 0.33000000000000002, 2.7000000000000002, 4, 7, 125, -55, "RF", "Дроссель: проволочный", 0.0, 2, 0.0, 270.0, 4.1399999999999997 },
                    { 25, 0.0, 4, 2.0, 5.0, 4, 7, 0, 0, "b82615", "Дроссель силовой", 250.0, 2, 0.0, 980.0, 0.5 },
                    { 26, 0.0, 4, 5.0, 0.25, 4, 7, 0, 0, "b82625", "Дроссель", 250.0, 2, 0.0, 1210.0, 0.071999999999999995 },
                    { 27, 0.0, 2, 0.0, 0.0, 6, 2, 155, -55, "smd 0402", "Чип резистор (SMD)", 50.0, 2, 0.062, 6.0, 1.2 },
                    { 28, 0.0, 1, 0.02, 0.0, 1, 8, 70, 0, null, "Кварцевый генератор", 5.0, 2, 0.0, 300.0, 0.0 },
                    { 29, 1.5, 4, 0.0, 0.0, 4, 9, 110, -40, "b32022", "Конденсатор подавления ЭМП", 300.0, 2, 0.0, 50.0, 0.0 },
                    { 30, 1000.0, 1, 0.0, 0.0, 9, 9, 125, -55, null, "Конденсатор танталовый SMD", 35.0, 2, 0.0, 28.0, 0.0 },
                    { 31, 0.0, 2, 0.0, 0.0, 6, 6, 85, -25, "fscq", "Импульсный регулятор напряжения", 650.0, 1, 210.0, 580.0, 0.0 },
                    { 32, 0.0, 2, 0.0, 0.0, 7, 7, 150, -40, "viper", "ШИМ-контроллер со встроенным силовым ключом", 730.0, 1, 8.0, 180.0, 0.0 },
                    { 33, 0.0, 6, 0.0, 0.0, 8, 7, 85, -40, "HMC273A", "Аттенюатор", 5.0, 1, 1.0, 2540.0, 50.0 },
                    { 34, 0.0, 6, 0.0, 0.0, 8, 7, 85, -40, "HMC658G", "Аттенюатор", 5.0, 1, 0.316, 2530.0, 50.0 },
                    { 35, 0.0, 6, 0.01, 0.0, 8, 6, 70, 0, "AD790JNZ", "Быстродействующий прецизионный компаратор напряжения", 4.0, 1, 0.0, 2700.0, 0.0 },
                    { 36, 0.0, 2, 0.0060000000000000001, 0.0, 7, 3, 85, -40, "LM211DT", "Дифференциальный компаратор со стробированием", 15.0, 1, 0.0, 53.0, 0.0 },
                    { 37, 0.0, 5, 0.002, 0.0, 5, 3, 70, 0, "LM2901DT", "Маломощный квадрантный компаратор напряжения", 15.0, 1, 0.0, 34.0, 0.0 },
                    { 38, 5000.0, 2, 0.0, 0.0, 6, 9, 70, -40, "CBB61", "Конденсатор пусковой", 450.0, 2, 0.0, 240.0, 0.0 },
                    { 39, 0.0, 1, 0.0, 0.0, 1, 3, 125, 1, "3540s", "Резистор прецизионный многооборотный", 0.0, 2, 2.0, 5700.0, 1000.0 },
                    { 40, 0.0, 1, 0.0, 0.0, 9, 3, 70, -10, "r24n1", "Резистор переменный", 500.0, 2, 0.5, 150.0, 1000.0 },
                    { 41, 0.0, 1, 0.0, 0.0, 9, 3, 70, -10, "rk-1112n", "Резистор переменный", 50.0, 2, 0.050000000000000003, 97.0, 1000.0 },
                    { 42, 0.012, 4, 0.0, 0.0, 4, 3, 125, -55, "к10-17б", "Конденсатор керамический выводной", 50.0, 2, 0.0, 7.0, 0.0 },
                    { 43, 0.0, 1, 0.5, 0.0, 9, 10, 85, -65, null, "Предохранитель стеклянный быстродействующий", 250.0, 2, 0.0, 15.0, 0.0 },
                    { 44, 0.0, 3, 0.63, 0.0, 10, 10, 85, -60, null, "Предохранитель", 250.0, 2, 0.0, 30.0, 0.0 },
                    { 45, 0.0, 3, 5.0, 0.0, 10, 10, 100, -60, null, "Предохранитель", 600.0, 2, 0.0, 54.0, 0.0 },
                    { 46, 0.0, 5, 4.0, 0.0, 5, 3, 100, -60, null, "Предохранитель керамический", 250.0, 2, 0.0, 33.0, 0.0 },
                    { 47, 0.0, 3, 0.10000000000000001, 0.0, 10, 3, 70, -60, null, "Предохранитель керамический", 350.0, 2, 0.0, 26.0, 0.0 },
                    { 48, 0.0, 1, 40.0, 0.0, 1, 3, 85, -40, "MF-R020", "Предохранитель самовосстанавливающийся", 60.0, 2, 0.40000000000000002, 38.0, 2.2000000000000002 },
                    { 49, 0.0, 1, 2.0, 0.0, 1, 6, 125, -55, "SF-1206SxxxM", "Плавкий предохранитель", 63.0, 2, 0.0, 130.0, 50.0 },
                    { 50, 0.0, 1, 0.0, 0.0, 1, 2, 155, -55, "CF-50", "Резистор углеродистый", 350.0, 2, 0.5, 9.0, 510.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Types",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Materials",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufacturers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Details",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Countries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
