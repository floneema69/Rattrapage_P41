using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataContext.Seed
{
    public static class VehicleSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehiculesModel>().HasData(
                new VehiculesModel { Vehiculeid = 1, EntrepriseID = 1, Nom = "Vehicle1", Marque = "Toyota", Modele = "Corolla", Immatriculation = "ABC123", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 2, EntrepriseID = 1, Nom = "Vehicle2", Marque = "Honda", Modele = "Civic", Immatriculation = "DEF456", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 3, EntrepriseID = 3, Nom = "Vehicle3", Marque = "Ford", Modele = "Focus", Immatriculation = "GHI789", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 4, EntrepriseID = 4, Nom = "Vehicle4", Marque = "Chevrolet", Modele = "Malibu", Immatriculation = "JKL012", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 5, EntrepriseID = 1, Nom = "Vehicle5", Marque = "Nissan", Modele = "Altima", Immatriculation = "MNO345", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 6, EntrepriseID = 3, Nom = "Vehicle6", Marque = "Hyundai", Modele = "Elantra", Immatriculation = "PQR678", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 7, EntrepriseID = 3, Nom = "Vehicle7", Marque = "Kia", Modele = "Optima", Immatriculation = "STU901", statut = true, description = "Bon etat" },
                new VehiculesModel { Vehiculeid = 8, EntrepriseID = 4, Nom = "Vehicle8", Marque = "Volkswagen", Modele = "Passat", Immatriculation = "VWX234", statut = true, description = "Bon etat" }
            );
        }
    }
}