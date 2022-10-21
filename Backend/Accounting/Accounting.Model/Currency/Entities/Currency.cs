namespace Accounting.Model.Currency.Entities;
public class Currency
{
    public int CurrencyId { get; set; }
    public string Title { get; set; }
    public string Symbol { get; set; }

    public ICollection<Users.Entities.User> Users { get; set; }
}
