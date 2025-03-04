using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataContext.Seed
{
    public static class EntreprisesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntreprisesModel>().HasData(
                new EntreprisesModel
                {
                    Entrepriseid = 1,
                    Nom = "Entreprise A",
                    ContratActif = true
                },
                new EntreprisesModel
                {
                    Entrepriseid = 2,
                    Nom = "Entreprise B",
                    ContratActif = false
                }
            );
        }
    }
}