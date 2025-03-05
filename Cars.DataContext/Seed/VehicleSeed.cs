using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataContext.Seed
{
    public static class VehicleSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehiculesModel>().HasData(
                new VehiculesModel { Vehiculeid = 1, EntrepriseID = 1, Nom = "Vehicle1", Marque = "Toyota", Modele = "Corolla", Immatriculation = "ABC123", statut = true },
                new VehiculesModel { Vehiculeid = 2, EntrepriseID = 2, Nom = "Vehicle2", Marque = "Honda", Modele = "Civic", Immatriculation = "DEF456", statut = true }
            );
        }
    }
}