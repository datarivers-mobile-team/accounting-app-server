using Accounting.Model.Users.Dtos;
using Accounting.Model.Users.Entities;

namespace Accounting.BLL.Users.Interfaces;
public interface IAccount
{
    Task RegisterAsync(RegisterDto user);

    Task<bool> Login(string cellPhoneNumber);
}
