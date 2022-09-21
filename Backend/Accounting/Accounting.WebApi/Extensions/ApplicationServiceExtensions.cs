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
        services.AddTransient<IAccount, UserAccount>();
        services.AddTransient<IOtpService, OtpService>();
        return services;
    }
}
