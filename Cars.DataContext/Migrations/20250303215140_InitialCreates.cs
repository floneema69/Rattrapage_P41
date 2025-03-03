using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
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
                name: "Salaries",
                columns: table => new
                {
                    Salarieid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entrepriseid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Salarieid);
                    table.ForeignKey(
                        name: "FK_Salaries_Entreprises_Entrepriseid",
                        column: x => x.Entrepriseid,
                        principalTable: "Entreprises",
                        principalColumn: "Entrepriseid",
                        onDelete: ReferentialAction.Cascade);
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
                name: "AttributionVehicule",
                columns: table => new
                {
                    VehiculeID = table.Column<int>(type: "int", nullable: false),
                    SalarieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributionVehicule", x => new { x.VehiculeID, x.SalarieID });
                    table.ForeignKey(
                        name: "FK_AttributionVehicule_Salaries_SalarieID",
                        column: x => x.SalarieID,
                        principalTable: "Salaries",
                        principalColumn: "Salarieid");
                    table.ForeignKey(
                        name: "FK_AttributionVehicule_Vehicules_VehiculeID",
                        column: x => x.VehiculeID,
                        principalTable: "Vehicules",
                        principalColumn: "Vehiculeid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributionVehicule_SalarieID",
                table: "AttributionVehicule",
                column: "SalarieID");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_Entrepriseid",
                table: "Salaries",
                column: "Entrepriseid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_EntrepriseID",
                table: "Vehicules",
                column: "EntrepriseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributionVehicule");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "Entreprises");
        }
    }
}
