using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.Currency;
public class CurencyConfig : IEntityTypeConfiguration<Model.Currency.Entities.Currency>
{
    public void Configure(EntityTypeBuilder<Model.Currency.Entities.Currency> builder)
    {
        builder.Property(c => c.Title).HasMaxLength(30);
        builder.Property(c => c.Symbol).HasMaxLength(100);

        builder
            .HasMany(c => c.Users)
            .WithOne(u => u.Currency)
            .HasForeignKey(u => u.CurrencyId);
    }
}
