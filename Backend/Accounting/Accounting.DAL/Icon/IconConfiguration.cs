using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.Icon;
public class IconConfiguration : IEntityTypeConfiguration<Model.Icon.Entities.Icon>
{
    public void Configure(EntityTypeBuilder<Model.Icon.Entities.Icon> builder)
    {
        builder.Property(i=>i.FileName).HasMaxLength(256);
        builder.Property(i=>i.Title).HasMaxLength(50);
    }
}
