namespace Accounting.Model.Icon.Entities;
public class Icon
{
    public int IconId { get; set; }

    public string Title { get; set; }

    public string FileName { get; set; }

    public byte IconType { get; set; }

    public int Oeder { get; set; }

    public ICollection<Account.Entities.Account> Accounts { get; set; }

    public ICollection<Category.Entities.Category> Categories { get; set; }

    public ICollection<Currency.Entities.Currency> Currencies { get; set; }
}
