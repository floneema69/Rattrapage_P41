
using Cars.DataContext.EntityTypeConfiguration;
using Cars.DataContext.Seed;
using Cars.Model;
using Cars.Model.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataContext;


     public class MainDbContext : IdentityDbContext<User>
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public DbSet<VehiculesModel> Vehicules { get; set; }
        public DbSet<SalariesModel> Salaries { get; set; }
        public DbSet<EntreprisesModel> Entreprises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehiculeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SalariesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntrepriseEntityTypeConfiguration());
            
             modelBuilder.Entity<User>()
                        .HasOne(u => u.Entreprise)
                        .WithMany(e => e.Users)
                        .HasForeignKey(u => u.EntrepriseId)
                        .OnDelete(DeleteBehavior.SetNull);
            EntreprisesSeed.Seed(modelBuilder);
            VehicleSeed.Seed(modelBuilder);
            SalariesSeed.Seed(modelBuilder);
            UserSeed.Seed(modelBuilder);
            
            base.OnModelCreating(modelBuilder);
        }
    }
