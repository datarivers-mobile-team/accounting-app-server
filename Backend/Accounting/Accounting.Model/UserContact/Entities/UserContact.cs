using Accounting.Model.Users.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Model.UserContact.Entities;
public class UserContact
{
    public int UserContactId { get; set; }
        
    public User UserOwner { get; set; }
    public int OwnerId { get; set; }

    public User User { get; set; }
    public int ContactId { get; set; }
}
