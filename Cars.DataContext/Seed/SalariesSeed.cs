using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataContext.Seed
{
    public static class SalariesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalariesModel>().HasData(
                new SalariesModel { Salarieid = 1, Nom = "John", Prenom = "Doe", Email = "john.doe@example.com", Entrepriseid = 1, Vehiculeid = 1 },
                new SalariesModel { Salarieid = 2, Nom = "Jane", Prenom = "Smith", Email = "jane.smith@example.com", Entrepriseid = 2, Vehiculeid = 2 },
                new SalariesModel { Salarieid = 3, Nom = "Alice", Prenom = "Johnson", Email = "alice.johnson@example.com", Entrepriseid = 1, Vehiculeid = null }
            );
        }
    }
}