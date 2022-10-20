using Accounting.BLL.Account.Classes;
using Accounting.BLL.Account.Interfaces;
using Accounting.BLL.Icon.Classes;
using Accounting.BLL.Icon.Interfaces;
using Accounting.BLL.Otp.Classes;
using Accounting.BLL.Otp.Interfaces;
using Accounting.BLL.Users.Classes;
using Accounting.BLL.Users.Interfaces;
using Accounting.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Accounting.WebApi.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<AccountingDbContext>(c => c.UseSqlServer(config.GetConnectionString("TestDbConnection")));
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IOtpService, OtpService>();
        services.AddTransient<IIconService, IconService>();
        services.AddTransient<IAccountService, AccountService>();

        return services;
    }
}
