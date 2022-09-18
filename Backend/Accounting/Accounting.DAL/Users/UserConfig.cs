using Accounting.Model.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.Users;
public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.FullName).HasMaxLength(150);
        builder.Property(u => u.PhoneNumber).HasMaxLength(15);
        builder.Property(u => u.RefCode).HasMaxLength(20);
    }
}
