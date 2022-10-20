namespace Accounting.Model.Users.Entities;
public class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string PhoneNumber { get; set; }

    public string? RefCode { get; set; }

    public int? PreferredCurrency { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual UserToken.Entities.UserToken UserToken { get; set; }

    public ICollection<UserAccount.Entities.UserAccount> UserAccounts { get; set; }
    public ICollection<UserContact.Entities.UserContact> UserContacts { get; set; }

    public ICollection<UserContact.Entities.UserContact> UserOwner { get; set; }

}
