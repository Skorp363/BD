using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD.Migrations
{
	/// <inheritdoc />
	public partial class BD4 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Details_Manufacturers_ManufacturerId",
				table: "Details");

			migrationBuilder.DropForeignKey(
				name: "FK_Details_Materials_MaterialId",
				table: "Details");

			migrationBuilder.DropForeignKey(
				name: "FK_Details_Types_Part_typeId",
				table: "Details");

			migrationBuilder.AlterColumn<int>(
				name: "Part_typeId",
				table: "Details",
				type: "integer",
				nullable: false,
				defaultValue: 0,
				oldClrType: typeof(int),
				oldType: "integer",
				oldNullable: true);

			migrationBuilder.AlterColumn<int>(
				name: "MaterialId",
				table: "Details",
				type: "integer",
				nullable: false,
				defaultValue: 0,
				oldClrType: typeof(int),
				oldType: "integer",
				oldNullable: true);

			migrationBuilder.AlterColumn<int>(
				name: "ManufacturerId",
				table: "Details",
				type: "integer",
				nullable: false,
				defaultValue: 0,
				oldClrType: typeof(int),
				oldType: "integer",
				oldNullable: true);

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Manufacturers_ManufacturerId",
				table: "Details",
				column: "ManufacturerId",
				principalTable: "Manufacturers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Materials_MaterialId",
				table: "Details",
				column: "MaterialId",
				principalTable: "Materials",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Types_Part_typeId",
				table: "Details",
				column: "Part_typeId",
				principalTable: "Types",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Details_Manufacturers_ManufacturerId",
				table: "Details");

			migrationBuilder.DropForeignKey(
				name: "FK_Details_Materials_MaterialId",
				table: "Details");

			migrationBuilder.DropForeignKey(
				name: "FK_Details_Types_Part_typeId",
				table: "Details");

			migrationBuilder.AlterColumn<int>(
				name: "Part_typeId",
				table: "Details",
				type: "integer",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "integer");

			migrationBuilder.AlterColumn<int>(
				name: "MaterialId",
				table: "Details",
				type: "integer",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "integer");

			migrationBuilder.AlterColumn<int>(
				name: "ManufacturerId",
				table: "Details",
				type: "integer",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "integer");

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Manufacturers_ManufacturerId",
				table: "Details",
				column: "ManufacturerId",
				principalTable: "Manufacturers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Materials_MaterialId",
				table: "Details",
				column: "MaterialId",
				principalTable: "Materials",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Types_Part_typeId",
				table: "Details",
				column: "Part_typeId",
				principalTable: "Types",
				principalColumn: "Id");
		}
	}
}
