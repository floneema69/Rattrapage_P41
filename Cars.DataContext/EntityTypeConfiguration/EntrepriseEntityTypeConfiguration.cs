using Cars.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cars.DataContext.EntityTypeConfiguration
{
    public class EntrepriseEntityTypeConfiguration : IEntityTypeConfiguration<EntreprisesModel>
    {
        public void Configure(EntityTypeBuilder<EntreprisesModel> builder)
        {
            builder.HasKey(e => e.Entrepriseid);
            
        }
    }
}