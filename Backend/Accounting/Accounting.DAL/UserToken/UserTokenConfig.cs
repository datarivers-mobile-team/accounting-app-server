using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.UserToken;
public class UserTokenConfig : IEntityTypeConfiguration<Model.UserToken.Entities.UserToken>
{
    public void Configure(EntityTypeBuilder<Model.UserToken.Entities.UserToken> builder)
    {
        builder.Property(ut => ut.Token).HasMaxLength(10);
    }
}
