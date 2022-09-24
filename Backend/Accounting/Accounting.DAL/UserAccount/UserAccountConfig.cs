using Accounting.Model.Account.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Model.UserAccount;
public class UserAccountConfig : IEntityTypeConfiguration<Account.Entities.Account>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Account.Entities.Account> builder)
    {
        builder.Property(a => a.Title).HasMaxLength(100);

        builder.Property<DateTime>("CreateAt");
        builder.Property<DateTime>("UpdateAt");
    }
}
