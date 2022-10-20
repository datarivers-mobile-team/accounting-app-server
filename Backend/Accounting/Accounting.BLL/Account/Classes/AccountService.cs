using Accounting.BLL.Account.Interfaces;
using Accounting.BLL.Framework;
using Accounting.DAL.DataContext;

namespace Accounting.BLL.Account.Classes;
public class AccountService : BaseApplicationService, IAccountService
{
    public AccountService(AccountingDbContext accountingDbContext) : base(accountingDbContext)
    {
    }

    public async Task CreateAccount(Model.Account.Entities.Account account)
    {
        await _accountingDbContext.Accounts.AddAsync(account);
        await _accountingDbContext.SaveChangesAsync();
    }
}
