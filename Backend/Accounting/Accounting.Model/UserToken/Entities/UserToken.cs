using Accounting.Model.Users.Entities;

namespace Accounting.Model.UserToken.Entities;
public class UserToken
{
    public int UserTokenId { get; set; }

    public string Token { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime ExpireAt { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }
}
