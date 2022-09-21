using Accounting.BLL.Framework;
using Accounting.BLL.Users.Interfaces;
using Accounting.DAL.DataContext;
using Accounting.Model.Users.Dtos;
using Accounting.Model.Users.Entities;
using Accounting.Utils;
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
        DateTime now = DateTime.Now;
        User user = new()
        {
            FullName = register.FullName,
            PhoneNumber = register.PhoneNumber,
            PreferredCurrency = register.PreferredCurrency,
            RefCode = register.RefCode,
            CreatedAt = now,
            Isdeleted = false,
            UserToken = new Model.UserToken.Entities.UserToken()
            {
                CreateAt = now,
                ExpireAt = now.AddMonths(1),
                Token = GenerateToken.GenerateUserToken()
            }
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

    public async Task<bool> Remove(int userId)
    {
        User? deletingUser = await _accountingDbContext.Users.SingleOrDefaultAsync
            (u => u.UserId.Equals(userId));

        if (deletingUser == null)
        {
            return false;
        }

        deletingUser.Isdeleted = true;
        await _accountingDbContext.SaveChangesAsync();

        return true;
    }
}
