using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cars.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entreprises",
                columns: new[] { "Entrepriseid", "ContratActif", "Nom" },
                values: new object[,]
                {
                    { 1, true, "Entreprise A" },
                    { 2, false, "Entreprise B" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entreprises",
                keyColumn: "Entrepriseid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entreprises",
                keyColumn: "Entrepriseid",
                keyValue: 2);
        }
    }
}
