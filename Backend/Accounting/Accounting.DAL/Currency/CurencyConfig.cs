using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

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

        SeedData(builder);
    }

    private void SeedData(EntityTypeBuilder<Model.Currency.Entities.Currency> builder)
    {
        List<Model.Currency.Entities.Currency> currencies = new List<Model.Currency.Entities.Currency>(2)
        {
          new Model.Currency.Entities.Currency   { CurrencyId = 1, Symbol = "$", Title = "Dollar",IconId=1},
          new Model.Currency.Entities.Currency   { CurrencyId=2, Symbol = "€", Title = "Euro",IconId=2}
        };

        foreach (var item in currencies)
        {
            builder.HasData(item);
        }
    }
}
