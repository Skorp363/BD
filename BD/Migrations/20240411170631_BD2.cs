using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD.Migrations
{
	/// <inheritdoc />
	public partial class BD2 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Details",
				keyColumn: "Id",
				keyValue: 1);

			migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Types",
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
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
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
				table: "Manufacturers",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			migrationBuilder.InsertData(
				table: "Details",
				columns: new[] { "Id", "Capacity", "CountryId", "Electric_current", "Inductance", "ManufacturerId", "MaterialId", "MaxOperating_Temp", "MinOperating_Temp", "Model", "Name", "Operating_voltage", "Part_typeId", "Power", "Price", "Resistance" },
				values: new object[] { 1, 0.0, null, 0.0, 0.0, null, null, 0, 0, null, null, 0.0, null, 0.0, 0.0, 0.0 });
		}
	}
}
