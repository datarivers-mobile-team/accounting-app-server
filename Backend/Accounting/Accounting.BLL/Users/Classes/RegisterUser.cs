using Accounting.BLL.Framework;
using Accounting.BLL.Users.Interfaces;
using Accounting.DAL.DataContext;
using Accounting.Model.Users.Dtos;
using Accounting.Model.Users.Entities;

namespace Accounting.BLL.Users.Classes;
public class RegisterUser : BaseApplicationService, IUser
{
    public RegisterUser(AccountingDbContext accountingDbContext)
        : base(accountingDbContext)
    {
    }

    public async Task RegisterAsync(RegisterDto register)
    {
        User user = new() 
        { FullName = register.FullName, PhoneNumber = register.PhoneNumber, 
          PreferredCurrency = register.PreferredCurrency, RefCode = register.RefCode };

        await _accountingDbContext.Users.AddAsync(user);
        await _accountingDbContext.SaveChangesAsync();
    }
}
