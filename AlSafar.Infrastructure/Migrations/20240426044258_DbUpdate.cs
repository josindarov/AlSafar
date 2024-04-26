using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlSafar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_TourCompanies_TourCompanyId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "TourCompanyId",
                table: "Clients",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_TourCompanyId",
                table: "Clients",
                newName: "IX_Clients_TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Tours_TourId",
                table: "Clients",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Tours_TourId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "Clients",
                newName: "TourCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_TourId",
                table: "Clients",
                newName: "IX_Clients_TourCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_TourCompanies_TourCompanyId",
                table: "Clients",
                column: "TourCompanyId",
                principalTable: "TourCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
