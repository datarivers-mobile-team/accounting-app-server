using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.Color;
public class ColorConfiguration : IEntityTypeConfiguration<Model.Color.Entities.Color>
{
    public void Configure(EntityTypeBuilder<Model.Color.Entities.Color> builder)
    {
        builder.Property(c => c.Value).HasMaxLength(50);
        builder.Property(c=>c.Title).HasMaxLength(50);
    }
}
