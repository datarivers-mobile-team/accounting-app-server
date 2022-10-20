using Accounting.Model.UserAccount.AccessType;

namespace Accounting.Model.UserAccount.Entities;
public class UserAccount
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int AccountId { get; set; }
    public AccessMode AccessMode { get; set; }
    public int Status { get; set; }
}
