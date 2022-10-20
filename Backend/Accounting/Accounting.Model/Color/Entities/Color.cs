using Accounting.Model.Color.Type;

namespace Accounting.Model.Color.Entities;
public class Color
{
    public int ColorId { get; set; }
    public string Value { get; set; }
    public string Title { get; set; }
    public ColorType ColorType { get; set; }

    public ICollection<Category.Entities.Category> Categories { get; set; }
    public ICollection<Account.Entities.Account> Accounts { get; set; }

}
