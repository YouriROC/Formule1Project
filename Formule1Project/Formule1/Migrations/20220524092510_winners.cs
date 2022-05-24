using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1MVC.Migrations
{
    public partial class winners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Circuit_CircuitID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Drivers_DriverID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Grandprix_GrandprixID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Teams_TeamID",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GrandprixID",
                table: "Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DriverID",
                table: "Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CircuitID",
                table: "Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Circuit_CircuitID",
                table: "Results",
                column: "CircuitID",
                principalTable: "Circuit",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Drivers_DriverID",
                table: "Results",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Grandprix_GrandprixID",
                table: "Results",
                column: "GrandprixID",
                principalTable: "Grandprix",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Teams_TeamID",
                table: "Results",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Circuit_CircuitID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Drivers_DriverID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Grandprix_GrandprixID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Teams_TeamID",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GrandprixID",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverID",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CircuitID",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Circuit_CircuitID",
                table: "Results",
                column: "CircuitID",
                principalTable: "Circuit",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Drivers_DriverID",
                table: "Results",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Grandprix_GrandprixID",
                table: "Results",
                column: "GrandprixID",
                principalTable: "Grandprix",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Teams_TeamID",
                table: "Results",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
