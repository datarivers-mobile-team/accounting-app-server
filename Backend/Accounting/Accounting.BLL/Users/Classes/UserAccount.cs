using Accounting.BLL.Framework;
using Accounting.BLL.Users.Interfaces;
using Accounting.DAL.DataContext;
using Accounting.Model.Users.Dtos;
using Accounting.Model.Users.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.BLL.Users.Classes;
public class UserAccount : BaseApplicationService, IAccount
{
    public UserAccount(AccountingDbContext accountingDbContext)
        : base(accountingDbContext)
    {
    }

    public async Task RegisterAsync(RegisterDto register)
    {
        User user = new()
        {
            FullName = register.FullName,
            PhoneNumber = register.PhoneNumber,
            PreferredCurrency = register.PreferredCurrency,
            RefCode = register.RefCode
        };

        await _accountingDbContext.Users.AddAsync(user);
        await _accountingDbContext.SaveChangesAsync();
    }

    public async Task<bool> Login(string cellPhoneNumber)
    {
        User? user = await _accountingDbContext.Users.
           SingleOrDefaultAsync(u => u.PhoneNumber.Equals(cellPhoneNumber));

        return user != null;
    }
}
