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
                new SalariesModel { Salarieid = 2, Nom = "Jane", Prenom = "Smith", Email = "jane.smith@example.com", Entrepriseid = 3, Vehiculeid = null }, 
                new SalariesModel { Salarieid = 3, Nom = "Alice", Prenom = "Johnson", Email = "alice.johnson@example.com", Entrepriseid = 1, Vehiculeid = null },
                new SalariesModel { Salarieid = 4, Nom = "Bob", Prenom = "Brown", Email = "bob.brown@example.com", Entrepriseid = 3, Vehiculeid = 3 },
                new SalariesModel { Salarieid = 5, Nom = "Charlie", Prenom = "Davis", Email = "charlie.davis@example.com", Entrepriseid = 4, Vehiculeid = 4 },
                new SalariesModel { Salarieid = 6, Nom = "Diana", Prenom = "Evans", Email = "diana.evans@example.com", Entrepriseid = 3, Vehiculeid = null },
                new SalariesModel { Salarieid = 7, Nom = "Eve", Prenom = "Foster", Email = "eve.foster@example.com", Entrepriseid = 1, Vehiculeid = 5 },
                new SalariesModel { Salarieid = 8, Nom = "Frank", Prenom = "Green", Email = "frank.green@example.com", Entrepriseid = 1, Vehiculeid = 6 },
                new SalariesModel { Salarieid = 9, Nom = "Grace", Prenom = "Harris", Email = "grace.harris@example.com", Entrepriseid = 4, Vehiculeid = null },
                new SalariesModel { Salarieid = 10, Nom = "Henry", Prenom = "Ivy", Email = "henry.ivy@example.com", Entrepriseid = 3, Vehiculeid = 7 },
                new SalariesModel { Salarieid = 11, Nom = "Ivy", Prenom = "Jones", Email = "ivy.jones@example.com", Entrepriseid = 2, Vehiculeid = null }, 
                new SalariesModel { Salarieid = 12, Nom = "Jack", Prenom = "King", Email = "jack.king@example.com", Entrepriseid = 4, Vehiculeid = null }

            );
        }
    }
}