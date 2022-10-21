using Accounting.Model.Account.Entities;
using Accounting.Model.Category.Entities;
using Accounting.Model.Color.Entities;
using Accounting.Model.Icon.Entities;
using Accounting.Model.UserAccount.Entities;
using Accounting.Model.Users.Entities;
using Accounting.Model.UserToken.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.DAL.DataContext;
public class AccountingDbContext : DbContext
{
    public AccountingDbContext(DbContextOptions<AccountingDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Model.UserToken.Entities.UserToken> UserTokens { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Model.Icon.Entities.Icon> Icons { get; set; }
    public DbSet<Model.UserContact.Entities.UserContact> UserContacts { get; set; }
    public DbSet<Model.Color.Entities.Color> Colors { get; set; }
    public DbSet<Model.Category.Entities.Category> Categories { get; set; }
    public DbSet<Model.Currency.Entities.Currency> Currencies { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}
