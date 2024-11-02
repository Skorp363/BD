using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class BD1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Director = table.Column<string>(type: "text", nullable: true),
                    Activity = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RssItems",
                columns: table => new
                {
                    Title = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PubDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    Part_typeId = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Operating_voltage = table.Column<double>(type: "double precision", nullable: true),
                    MinOperating_Temp = table.Column<int>(type: "integer", nullable: true),
                    MaxOperating_Temp = table.Column<int>(type: "integer", nullable: true),
                    Capacity = table.Column<double>(type: "double precision", nullable: true),
                    Power = table.Column<double>(type: "double precision", nullable: true),
                    Resistance = table.Column<double>(type: "double precision", nullable: true),
                    Electric_current = table.Column<double>(type: "double precision", nullable: true),
                    Inductance = table.Column<double>(type: "double precision", nullable: true),
                    MaterialId = table.Column<int>(type: "integer", nullable: false),
                    ManufacturerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Types_Part_typeId",
                        column: x => x.Part_typeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "TW", "Тайвань" },
                    { 2, "CN", "Китай" },
                    { 3, "RU", "Россия" },
                    { 4, "DE", "Германия" },
                    { 5, "JP", "Япония" },
                    { 6, "US", "США" },
                    { 7, "CH", "Швейцария" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Activity", "Address", "Country", "Director", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Electronics", "Риверсайд, Калифорния", "США", "Гордон Борнс", "BOURNS", null },
                    { 2, "Electronics", "г. Хэфей, провинция Аньхой, КНР; г. Дунгуан, провинция Гуаньдун.", "Китай", null, "JB Capacitors", "+8-522-790-50-91" },
                    { 3, "Electronics", "Форт-Лодердейл, Флорида", "США", null, "Kemet Electronics", null },
                    { 4, "Electronics", "Мюнхен", "Германия", null, "EPCOS", null },
                    { 5, "Electronics", "Нагаокакё, Киото", "Япония", "Норио Накадзима", "Murata Electronics", null },
                    { 6, "Electronics", " Финикс, Аризона", "США", "Хассан Эль-Хури", "ON Semiconductor", null },
                    { 7, "Electronics", "Женева", "Швейцария", "Жан-Марк Чери, Remi El-Ouazzane", "STMicroelectronics", null },
                    { 8, "Semiconductor", "Уилмингтон, Массачусетс", "США", "Венсан Рош", "Analog Devices", null },
                    { 9, "Electronics", "4F-1, № 288-7, ShinYa Road, район Чиен Чен, Гаосюн, 80673", "Тайвань", null, "Song Huei Electronic", "+8-867-815-00-38" },
                    { 10, "Electronics", "431110, Республика Мордовия, п. Зубова Поляна, ул. Новикова-Прибоя, 35.", "Россия", "Казеев Александр Александрович", "ОАО \"Радиодеталь\"", "+7-834-582-11-50" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Металлокерамика" },
                    { 2, 2, "Углерод" },
                    { 3, 3, "Керамика" },
                    { 4, 4, "Бумага" },
                    { 5, 5, "Плёнка" },
                    { 6, 6, "Медь" },
                    { 7, 7, "Феррит" },
                    { 8, 8, "Кварц" },
                    { 9, 9, "Полипропилен" },
                    { 10, 10, "Стекло" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Активный" },
                    { 2, 2, "Пассивный" },
                    { 3, 3, "Подстроечный" }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Capacity", "CountryId", "Electric_current", "Inductance", "ManufacturerId", "MaterialId", "MaxOperating_Temp", "MinOperating_Temp", "Model", "Name", "Operating_voltage", "Part_typeId", "Power", "Price", "Resistance" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, 1, 2, 155, -55, "CF-100", "Резистор углеродистый", 500.0, 2, 1.0, 9.0, 1.0 },
                    { 2, null, 1, null, null, 1, 2, 155, -55, "CF-100", "Резистор углеродистый", 500.0, 2, 1.0, 9.0, 100.0 },
                    { 3, null, 1, null, null, 1, 2, 155, -55, "CF-100", "Резистор углеродистый", 500.0, 2, 1.0, 9.0, 510.0 },
                    { 4, null, 1, null, null, 3, 2, 275, -55, "AH-100", "Резистор силовой", 1900.0, 2, 100.0, 1540.0, 0.10000000000000001 },
                    { 5, null, 1, null, null, 3, 2, 275, -55, "AH-100", "Резистор силовой", 1900.0, 2, 100.0, 1530.0, 1.5 },
                    { 6, null, 1, null, null, 3, 2, 275, -55, "AH-100", "Резистор силовой", 1900.0, 2, 100.0, 1540.0, 1000.0 },
                    { 7, null, 1, null, null, 1, 1, 125, -55, "3006", "Резистор подстроечный", 1000.0, 3, 0.75, 150.0, 100.0 },
                    { 8, null, 1, null, null, 1, 1, 150, -65, "3224", "Резистор подстроечный", 600.0, 3, 0.25, 200.0, 1000.0 },
                    { 9, null, 1, null, null, 1, 1, 150, -65, "3266", "Резистор подстроечный", 600.0, 3, 0.25, 220.0, 50.0 },
                    { 10, 0.10000000000000001, 2, null, null, 2, 3, 85, -25, "JYC", "Конденсатор керамический дисковый", 2000.0, 2, null, 15.0, null },
                    { 11, 2.2000000000000002, 1, null, null, 3, 4, 100, -40, null, "Конденсатор бумажный", 500.0, 2, null, 330.0, null },
                    { 12, 0.25, 4, null, null, 4, 4, 60, -60, "ОМБГ-3", "Конденсатор бумажный", 400.0, 2, null, 210.0, null },
                    { 13, 1.0, 2, null, null, 2, 5, 85, -45, "JFA", "Конденсатор металлоплёночный", 100.0, 2, null, 10.0, null },
                    { 14, 180.0, 3, null, null, 10, 5, 125, -60, "полиэстер", "Конденсатор металлоплёночный", 63.0, 2, null, 33.0, null },
                    { 15, 65000.0, 4, null, null, 4, 5, 65, -25, "b32320i", "Конденсатор плёночный", 350.0, 2, null, 1330.0, null },
                    { 16, 0.012500000000000001, 5, null, null, 5, 5, 85, -25, "tzc3", "Конденсатор подстроечный", 100.0, 3, null, 200.0, null },
                    { 17, 0.0022000000000000001, 2, null, null, 6, 3, 85, -25, "tzc3", "Конденсатор подстроечный", 100.0, 3, null, 280.0, null },
                    { 18, null, 2, 0.37, 0.01, 6, 6, 100, -20, "ec24", "Индуктивный элемент", null, 2, null, 15.0, 0.71999999999999997 },
                    { 19, null, 3, 0.20000000000000001, 0.047, 10, 6, 100, -20, "киг", "Катушка индуктивности", null, 2, null, 110.0, 11.0 },
                    { 20, null, 4, 0.025000000000000001, 0.01, 4, 6, 125, -40, null, "Катушка индуктивности", null, 2, null, 530.0, null },
                    { 21, null, 1, null, 0.01, 1, 6, 100, -20, "cm322522", "Индуктивность SMD", null, 2, null, 31.0, 2.1000000000000001 },
                    { 22, null, 5, 0.10000000000000001, 30.0, 5, 6, null, null, "bla", "Индуктивность для подавления ЭПМ", null, 2, null, 49.0, 600.0 },
                    { 23, null, 5, 0.29999999999999999, 36.0, 5, 6, 60, -25, "pla", "Фильтр подавления ЭПМ", 300.0, 2, null, 170.0, null },
                    { 24, null, 4, 0.33000000000000002, 2.7000000000000002, 4, 7, 125, -55, "RF", "Дроссель: проволочный", null, 2, null, 270.0, 4.1399999999999997 },
                    { 25, null, 4, 2.0, 5.0, 4, 7, null, null, "b82615", "Дроссель силовой", 250.0, 2, null, 980.0, 0.5 },
                    { 26, null, 4, 5.0, 0.25, 4, 7, null, null, "b82625", "Дроссель", 250.0, 2, null, 1210.0, 0.071999999999999995 },
                    { 27, null, 2, null, null, 6, 2, 155, -55, "smd 0402", "Чип резистор (SMD)", 50.0, 2, 0.062, 6.0, 1.2 },
                    { 28, null, 1, 0.02, null, 1, 8, 70, 0, null, "Кварцевый генератор", 5.0, 2, null, 300.0, null },
                    { 29, 1.5, 4, null, null, 4, 9, 110, -40, "b32022", "Конденсатор подавления ЭМП", 300.0, 2, null, 50.0, null },
                    { 30, 1000.0, 1, null, null, 9, 9, 125, -55, null, "Конденсатор танталовый SMD", 35.0, 2, null, 28.0, null },
                    { 31, null, 2, null, null, 6, 6, 85, -25, "fscq", "Импульсный регулятор напряжения", 650.0, 1, 210.0, 580.0, null },
                    { 32, null, 2, null, null, 7, 7, 150, -40, "viper", "ШИМ-контроллер со встроенным силовым ключом", 730.0, 1, 8.0, 180.0, null },
                    { 33, null, 6, null, null, 8, 7, 85, -40, "HMC273A", "Аттенюатор", 5.0, 1, 1.0, 2540.0, 50.0 },
                    { 34, null, 6, null, null, 8, 7, 85, -40, "HMC658G", "Аттенюатор", 5.0, 1, 0.316, 2530.0, 50.0 },
                    { 35, null, 6, 0.01, null, 8, 6, 70, 0, "AD790JNZ", "Быстродействующий прецизионный компаратор напряжения", 4.0, 1, null, 2700.0, null },
                    { 36, null, 2, 0.0060000000000000001, null, 7, 3, 85, -40, "LM211DT", "Дифференциальный компаратор со стробированием", 15.0, 1, null, 53.0, null },
                    { 37, null, 5, 0.002, null, 5, 3, 70, 0, "LM2901DT", "Маломощный квадрантный компаратор напряжения", 15.0, 1, null, 34.0, null },
                    { 38, 5000.0, 2, null, null, 6, 9, 70, -40, "CBB61", "Конденсатор пусковой", 450.0, 2, null, 240.0, null },
                    { 39, null, 1, null, null, 1, 3, 125, 1, "3540s", "Резистор прецизионный многооборотный", null, 2, 2.0, 5700.0, 1000.0 },
                    { 40, null, 1, null, null, 9, 3, 70, -10, "r24n1", "Резистор переменный", 500.0, 2, 0.5, 150.0, 1000.0 },
                    { 41, null, 1, null, null, 9, 3, 70, -10, "rk-1112n", "Резистор переменный", 50.0, 2, 0.050000000000000003, 97.0, 1000.0 },
                    { 42, 0.012, 4, null, null, 4, 3, 125, -55, "к10-17б", "Конденсатор керамический выводной", 50.0, 2, null, 7.0, null },
                    { 43, null, 1, 0.5, null, 9, 10, 85, -65, null, "Предохранитель стеклянный быстродействующий", 250.0, 2, null, 15.0, null },
                    { 44, null, 3, 0.63, null, 10, 10, 85, -60, null, "Предохранитель", 250.0, 2, null, 30.0, null },
                    { 45, null, 3, 5.0, null, 10, 10, 100, -60, null, "Предохранитель", 600.0, 2, null, 54.0, null },
                    { 46, null, 5, 4.0, null, 5, 3, 100, -60, null, "Предохранитель керамический", 250.0, 2, null, 33.0, null },
                    { 47, null, 3, 0.10000000000000001, null, 10, 3, 70, -60, null, "Предохранитель керамический", 350.0, 2, null, 26.0, null },
                    { 48, null, 1, 40.0, null, 1, 3, 85, -40, "MF-R020", "Предохранитель самовосстанавливающийся", 60.0, 2, 0.40000000000000002, 38.0, 2.2000000000000002 },
                    { 49, null, 1, 2.0, null, 1, 6, 125, -55, "SF-1206SxxxM", "Плавкий предохранитель", 63.0, 2, null, 130.0, 50.0 },
                    { 50, null, 1, null, null, 1, 2, 155, -55, "CF-50", "Резистор углеродистый", 350.0, 2, 0.5, 9.0, 510.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_CountryId",
                table: "Details",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_ManufacturerId",
                table: "Details",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_MaterialId",
                table: "Details",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_Part_typeId",
                table: "Details",
                column: "Part_typeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "RssItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
