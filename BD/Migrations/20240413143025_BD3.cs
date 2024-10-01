using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD.Migrations
{
	/// <inheritdoc />
	public partial class BD3 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Details_Countries_CountryId",
				table: "Details");

			migrationBuilder.AlterColumn<int>(
				name: "CountryId",
				table: "Details",
				type: "integer",
				nullable: false,
				defaultValue: 0,
				oldClrType: typeof(int),
				oldType: "integer",
				oldNullable: true);

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Countries_CountryId",
				table: "Details",
				column: "CountryId",
				principalTable: "Countries",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Details_Countries_CountryId",
				table: "Details");

			migrationBuilder.AlterColumn<int>(
				name: "CountryId",
				table: "Details",
				type: "integer",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "integer");

			migrationBuilder.AddForeignKey(
				name: "FK_Details_Countries_CountryId",
				table: "Details",
				column: "CountryId",
				principalTable: "Countries",
				principalColumn: "Id");
		}
	}
}
