using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    public partial class mig_carstatusıd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarStatuses_CarStatusID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarStatusID",
                table: "Cars",
                newName: "CarStatusID1");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarStatusID",
                table: "Cars",
                newName: "IX_Cars_CarStatusID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarStatuses_CarStatusID1",
                table: "Cars",
                column: "CarStatusID1",
                principalTable: "CarStatuses",
                principalColumn: "CarStatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarStatuses_CarStatusID1",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarStatusID1",
                table: "Cars",
                newName: "CarStatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarStatusID1",
                table: "Cars",
                newName: "IX_Cars_CarStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarStatuses_CarStatusID",
                table: "Cars",
                column: "CarStatusID",
                principalTable: "CarStatuses",
                principalColumn: "CarStatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
