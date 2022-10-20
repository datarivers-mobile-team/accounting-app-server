using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.DAL.Category;
public class CategoryConfiguration : IEntityTypeConfiguration<Model.Category.Entities.Category>
{
    public void Configure(EntityTypeBuilder<Model.Category.Entities.Category> builder)
    {
    }
}
