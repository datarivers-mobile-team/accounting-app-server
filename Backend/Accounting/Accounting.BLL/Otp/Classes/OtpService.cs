using Accounting.BLL.Framework;
using Accounting.BLL.Otp.Interfaces;
using Accounting.DAL.DataContext;
using Accounting.Model.Users.Entities;
using Accounting.Model.UserToken.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.BLL.Otp.Classes;
public class OtpService : BaseApplicationService,IOtpService
{
    public OtpService(AccountingDbContext accountingDbContext)
        :base(accountingDbContext)
    {
    }
    public async Task<string> GetOtpCodeAsync(string cellPhoneNumber)
    {
        User? user= await _accountingDbContext.Users.Include(u=>u.UserToken).SingleOrDefaultAsync
            (u => u.PhoneNumber.Equals(cellPhoneNumber));

        if (user == null)
        {
            return null;
        }

        return user.UserToken.Token;
    }
}
