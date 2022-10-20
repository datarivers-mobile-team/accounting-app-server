namespace Accounting.BLL.Account.Interfaces;
public interface IAccountService
{
    Task CreateAccount(Model.Account.Entities.Account account);
}
