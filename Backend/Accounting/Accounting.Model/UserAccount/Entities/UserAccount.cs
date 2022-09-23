namespace Accounting.Model.UserAccount.Entities;
public class UserAccount
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int AccountId { get; set; }
    public int AccessMode { get; set; }
    public int Status { get; set; }
}
