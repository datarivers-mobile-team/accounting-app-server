using Accounting.Model.Users.Entities;

public class UserContact
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int ContactId { get; set; }

    public virtual ICollection<User> Owner { get; set; }
    public virtual ICollection<User> Contact { get; set; }

}
