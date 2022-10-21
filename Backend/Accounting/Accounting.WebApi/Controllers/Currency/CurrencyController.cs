using Accounting.BLL.Currency.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers.Currency;

/// <summary>
/// This class for currency API
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class CurrencyController : ControllerBase
{
    private readonly ICurrencyService _currencyService;

    public CurrencyController(ICurrencyService currencyService)
    {
        _currencyService = currencyService;
    }

    /// <summary>
    /// Get all currency service
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> GetCurrency()
    {
        return Ok(await _currencyService.GetCurrencyListAsync());
    }
}
