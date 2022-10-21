using Accounting.BLL.Currency.Interfaces;
using Accounting.BLL.Framework;
using Accounting.DAL.DataContext;
using Accounting.Model.Currency.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Accounting.BLL.Currency.Classes;
public class CurrencyService : BaseApplicationService, ICurrencyService
{
    private readonly IMapper _mapper;

    public CurrencyService(AccountingDbContext accountingDbContext,IMapper mapper) 
        : base(accountingDbContext)
    {
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<CurrencyDto>> GetCurrencyListAsync()
    {
        List<Model.Currency.Entities.Currency> currencies = await _accountingDbContext.Currencies.AsNoTracking().ToListAsync();
        IReadOnlyList<CurrencyDto> currencyDtos = _mapper.Map<IReadOnlyList<CurrencyDto>>(currencies);

        return currencyDtos;

    }
}
