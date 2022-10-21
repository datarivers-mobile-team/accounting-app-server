using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.Icon;
public class IconConfiguration : IEntityTypeConfiguration<Model.Icon.Entities.Icon>
{
    public void Configure(EntityTypeBuilder<Model.Icon.Entities.Icon> builder)
    {
        builder.Property(i => i.FileName).HasMaxLength(256);
        builder.Property(i => i.Title).HasMaxLength(50);

        builder
            .HasMany(i => i.Currencies)
            .WithOne(c => c.Icon)
            .HasForeignKey(c => c.IconId);

        SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<Model.Icon.Entities.Icon> builder)
    {
        List<Model.Icon.Entities.Icon> icons = new List<Model.Icon.Entities.Icon>(2)
        {
          new Model.Icon.Entities.Icon   { IconId = 1,Title="Dollar",FileName="",IconType = 3,Oeder = 0},
          new Model.Icon.Entities.Icon   { IconId = 2,Title="Euro",FileName="",IconType = 3,Oeder = 0}
        };

        foreach (var item in icons)
        {
            builder.HasData(item);
        }
    }
}
