using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cars.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class SeedVehicules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Vehiculeid", "EntrepriseID", "Immatriculation", "Marque", "Modele", "Nom", "statut" },
                values: new object[,]
                {
                    { 1, 1, "ABC123", "Toyota", "Corolla", "Vehicle1", "Active" },
                    { 2, 2, "DEF456", "Honda", "Civic", "Vehicle2", "Inactive" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Vehiculeid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Vehiculeid",
                keyValue: 2);
        }
    }
}
