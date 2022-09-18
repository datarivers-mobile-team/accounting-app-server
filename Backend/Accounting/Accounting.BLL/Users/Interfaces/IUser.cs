using Accounting.Model.Users.Dtos;
using Accounting.Model.Users.Entities;

namespace Accounting.BLL.Users.Interfaces;
public interface IUser
{
    Task RegisterAsync(RegisterDto user);
}
