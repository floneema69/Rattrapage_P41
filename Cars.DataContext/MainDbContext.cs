
using Cars.DataContext.EntityTypeConfiguration;
using Cars.DataContext.Seed;
using Cars.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataContext;


     public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public DbSet<VehiculesModel> Vehicules { get; set; }
        public DbSet<SalariesModel> Salaries { get; set; }
        public DbSet<EntreprisesModel> Entreprises { get; set; }
        public DbSet<AttributionVehiculeModel> AttributionVehicule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehiculeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AttributionVehiculeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SalariesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntrepriseEntityTypeConfiguration());
            
            EntreprisesSeed.Seed(modelBuilder);
        }
    }
