using Cars.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.DataContext.EntityTypeConfiguration
{
    public class SalariesEntityTypeConfiguration : IEntityTypeConfiguration<SalariesModel>
    {
        public void Configure(EntityTypeBuilder<SalariesModel> builder)
        {
            builder.HasKey(s => s.Salarieid);

            builder.HasOne(s => s.Entreprise)
                .WithMany(e => e.Salaries)
                .HasForeignKey(s => s.Entrepriseid)
                .OnDelete(DeleteBehavior.NoAction); 

            builder.HasOne(s => s.Vehicule)
                .WithOne(v => v.Salarie)
                .HasForeignKey<SalariesModel>(s => s.Vehiculeid)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}