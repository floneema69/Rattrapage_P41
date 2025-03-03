using Cars.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.DataContext.EntityTypeConfiguration
{
    public class AttributionVehiculeEntityTypeConfiguration : IEntityTypeConfiguration<AttributionVehiculeModel>
    {
        public void Configure(EntityTypeBuilder<AttributionVehiculeModel> builder)
        {
            builder.HasKey(av => new { av.VehiculeID, av.SalarieID });

            builder.HasOne(av => av.Vehicule)
                .WithMany(v => v.AttributionVehicules)
                .HasForeignKey(av => av.VehiculeID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(av => av.Salarie)
                .WithMany(s => s.AttributionVehicules)
                .HasForeignKey(av => av.SalarieID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}