namespace Accounting.Model.Account.Entities;
public class Account
{
    public int AccountId { get; set; }
    public string Title { get; set; }
    public int StartAmount { get; set; }

    public ICollection<UserAccount.Entities.UserAccount> UserAccounts { get; set; }

}
