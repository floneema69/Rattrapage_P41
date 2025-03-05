using Cars.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.DataContext.EntityTypeConfiguration
{
    public class VehiculeEntityTypeConfiguration : IEntityTypeConfiguration<VehiculesModel>
    {
        public void Configure(EntityTypeBuilder<VehiculesModel> builder)
        {
            builder.HasKey(v => v.Vehiculeid);
          

            builder.HasOne(v => v.Entreprise)
                .WithMany(e => e.Vehicules)
                .HasForeignKey(v => v.EntrepriseID);
            
            builder.HasOne(v => v.Salarie)
                .WithOne(s => s.Vehicule)
                .HasForeignKey<SalariesModel>(s => s.Vehiculeid)  
                .OnDelete(DeleteBehavior.NoAction);  
        }
        }
            
        }
    