using Microsoft.EntityFrameworkCore.Migrations;

namespace HRWorkAnalyse.Data.Migrations
{
    public partial class permitentityfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permits_Employees_EmployeeId",
                table: "Permits");

            migrationBuilder.DropForeignKey(
                name: "FK_Permits_Titles_TitleId",
                table: "Permits");

            migrationBuilder.DropIndex(
                name: "IX_Permits_EmployeeId",
                table: "Permits");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Permits");

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Permits",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Permits_Titles_TitleId",
                table: "Permits",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permits_Titles_TitleId",
                table: "Permits");

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Permits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Permits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Permits_EmployeeId",
                table: "Permits",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permits_Employees_EmployeeId",
                table: "Permits",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permits_Titles_TitleId",
                table: "Permits",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
