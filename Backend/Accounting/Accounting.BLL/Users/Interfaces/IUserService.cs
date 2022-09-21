using Accounting.Model.Users.Dtos;
using Accounting.Model.Users.Entities;

namespace Accounting.BLL.Users.Interfaces;
public interface IUserService
{
    Task RegisterAsync(RegisterDto user);

    Task<bool> Login(string cellPhoneNumber);

    Task<List<User>> GetUsersAsync();

    Task<bool> Remove(int userId);
}
