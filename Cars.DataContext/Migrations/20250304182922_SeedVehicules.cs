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
            migrationBuilder.CreateTable(
                name: "Entreprises",
                columns: table => new
                {
                    Entrepriseid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContratActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprises", x => x.Entrepriseid);
                });

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    Vehiculeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrepriseID = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Immatriculation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    statut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.Vehiculeid);
                    table.ForeignKey(
                        name: "FK_Vehicules_Entreprises_EntrepriseID",
                        column: x => x.EntrepriseID,
                        principalTable: "Entreprises",
                        principalColumn: "Entrepriseid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Salarieid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entrepriseid = table.Column<int>(type: "int", nullable: false),
                    Vehiculeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Salarieid);
                    table.ForeignKey(
                        name: "FK_Salaries_Entreprises_Entrepriseid",
                        column: x => x.Entrepriseid,
                        principalTable: "Entreprises",
                        principalColumn: "Entrepriseid");
                    table.ForeignKey(
                        name: "FK_Salaries_Vehicules_Vehiculeid",
                        column: x => x.Vehiculeid,
                        principalTable: "Vehicules",
                        principalColumn: "Vehiculeid");
                });

            migrationBuilder.InsertData(
                table: "Entreprises",
                columns: new[] { "Entrepriseid", "ContratActif", "Nom" },
                values: new object[,]
                {
                    { 1, true, "Entreprise A" },
                    { 2, false, "Entreprise B" }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Salarieid", "Email", "Entrepriseid", "Nom", "Prenom", "Vehiculeid" },
                values: new object[] { 3, "alice.johnson@example.com", 1, "Alice", "Johnson", null });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Vehiculeid", "EntrepriseID", "Immatriculation", "Marque", "Modele", "Nom", "statut" },
                values: new object[,]
                {
                    { 1, 1, "ABC123", "Toyota", "Corolla", "Vehicle1", "Active" },
                    { 2, 2, "DEF456", "Honda", "Civic", "Vehicle2", "Inactive" }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "Salarieid", "Email", "Entrepriseid", "Nom", "Prenom", "Vehiculeid" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", 1, "John", "Doe", 1 },
                    { 2, "jane.smith@example.com", 2, "Jane", "Smith", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_Entrepriseid",
                table: "Salaries",
                column: "Entrepriseid");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_Vehiculeid",
                table: "Salaries",
                column: "Vehiculeid",
                unique: true,
                filter: "[Vehiculeid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_EntrepriseID",
                table: "Vehicules",
                column: "EntrepriseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "Entreprises");
        }
    }
}
