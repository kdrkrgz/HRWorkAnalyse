using Microsoft.EntityFrameworkCore.Migrations;

namespace HRWorkAnalyse.Data.Migrations
{
    public partial class Phonecallsfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneCalls_Employees_EmployeeId",
                table: "PhoneCalls");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PhoneCalls",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneCalls_Employees_EmployeeId",
                table: "PhoneCalls",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneCalls_Employees_EmployeeId",
                table: "PhoneCalls");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PhoneCalls",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneCalls_Employees_EmployeeId",
                table: "PhoneCalls",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
