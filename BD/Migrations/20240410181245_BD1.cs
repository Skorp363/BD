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
					Code = table.Column<string>(type: "text", nullable: true),
					Name = table.Column<string>(type: "text", nullable: true)
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
					Schedule = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
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
					Name = table.Column<string>(type: "text", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Materials", x => x.Id);
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
				name: "Details",
				columns: table => new
				{
					Id = table.Column<int>(type: "integer", nullable: false)
						.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
					Name = table.Column<string>(type: "text", nullable: true),
					Price = table.Column<double>(type: "double precision", nullable: false),
					CountryId = table.Column<int>(type: "integer", nullable: true),
					Part_typeId = table.Column<int>(type: "integer", nullable: true),
					Model = table.Column<string>(type: "text", nullable: true),
					Operating_voltage = table.Column<double>(type: "double precision", nullable: false),
					MinOperating_Temp = table.Column<int>(type: "integer", nullable: false),
					MaxOperating_Temp = table.Column<int>(type: "integer", nullable: false),
					Capacity = table.Column<double>(type: "double precision", nullable: false),
					Power = table.Column<double>(type: "double precision", nullable: false),
					Resistance = table.Column<double>(type: "double precision", nullable: false),
					Electric_current = table.Column<double>(type: "double precision", nullable: false),
					Inductance = table.Column<double>(type: "double precision", nullable: false),
					MaterialId = table.Column<int>(type: "integer", nullable: true),
					ManufacturerId = table.Column<int>(type: "integer", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Details", x => x.Id);
					table.ForeignKey(
						name: "FK_Details_Countries_CountryId",
						column: x => x.CountryId,
						principalTable: "Countries",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Details_Manufacturers_ManufacturerId",
						column: x => x.ManufacturerId,
						principalTable: "Manufacturers",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Details_Materials_MaterialId",
						column: x => x.MaterialId,
						principalTable: "Materials",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Details_Types_Part_typeId",
						column: x => x.Part_typeId,
						principalTable: "Types",
						principalColumn: "Id");
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
				table: "Details",
				columns: new[] { "Id", "Capacity", "CountryId", "Electric_current", "Inductance", "ManufacturerId", "MaterialId", "MaxOperating_Temp", "MinOperating_Temp", "Model", "Name", "Operating_voltage", "Part_typeId", "Power", "Price", "Resistance" },
				values: new object[] { 1, 0.0, null, 0.0, 0.0, null, null, 0, 0, null, null, 0.0, null, 0.0, 0.0, 0.0 });

			migrationBuilder.InsertData(
				table: "Manufacturers",
				columns: new[] { "Id", "Activity", "Address", "Country", "Director", "Name", "Phone", "Schedule" },
				values: new object[,]
				{
					{ 1, "Electronics", "Риверсайд, Калифорния", "США", "Гордон Борнс", "BOURNS", null, new TimeOnly(0, 0, 0) },
					{ 2, "Electronics", "г. Хэфей, провинция Аньхой, КНР; г. Дунгуан, провинция Гуаньдун.", "Китай", null, "JB Capacitors", "+8-522-790-50-91", new TimeOnly(0, 0, 0) },
					{ 3, "Electronics", "Форт-Лодердейл, Флорида", "США", null, "Kemet Electronics", null, new TimeOnly(0, 0, 0) },
					{ 4, "Electronics", "Мюнхен", "Германия", null, "EPCOS", null, new TimeOnly(0, 0, 0) },
					{ 5, "Electronics", "Нагаокакё, Киото", "Япония", "Норио Накадзима", "Murata Electronics", null, new TimeOnly(0, 0, 0) },
					{ 6, "Electronics", " Финикс, Аризона", "США", "Хассан Эль-Хури", "ON Semiconductor", null, new TimeOnly(0, 0, 0) },
					{ 7, "Electronics", "Женева", "Швейцария", "Жан-Марк Чери, Remi El-Ouazzane", "STMicroelectronics", null, new TimeOnly(0, 0, 0) },
					{ 8, "Semiconductor", "Уилмингтон, Массачусетс", "США", "Венсан Рош", "Analog Devices", null, new TimeOnly(0, 0, 0) },
					{ 9, "Electronics", "4F-1, № 288-7, ShinYa Road, район Чиен Чен, Гаосюн, 80673", "Тайвань", null, "Song Huei Electronic", "+8-867-815-00-38", new TimeOnly(0, 0, 0) },
					{ 10, "Electronics", "431110, Республика Мордовия, п. Зубова Поляна, ул. Новикова-Прибоя, 35.", "Россия", "Казеев Александр Александрович", "ОАО \"Радиодеталь\"", "+7-834-582-11-50", new TimeOnly(0, 0, 0) }
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
