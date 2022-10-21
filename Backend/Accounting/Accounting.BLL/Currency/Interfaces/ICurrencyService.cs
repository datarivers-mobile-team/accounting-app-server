using Accounting.Model.Currency.Dtos;

namespace Accounting.BLL.Currency.Interfaces;
public interface ICurrencyService
{
    Task<IReadOnlyList<CurrencyDto>> GetCurrencyListAsync();
}
