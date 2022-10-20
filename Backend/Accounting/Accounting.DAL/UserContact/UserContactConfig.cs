using Accounting.Model.UserContact.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.DAL.UserContact;
public class UserContactConfig : IEntityTypeConfiguration<Model.UserContact.Entities.UserContact>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Model.UserContact.Entities.UserContact> builder)
    {
        builder.HasOne(u => u.UserOwner)            
            .WithMany(u => u.UserContacts)
            .HasForeignKey(u => u.OwnerId)            
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.HasOne(u => u.User)
            .WithMany(u => u.UserOwner)
            .HasForeignKey(u => u.ContactId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}
