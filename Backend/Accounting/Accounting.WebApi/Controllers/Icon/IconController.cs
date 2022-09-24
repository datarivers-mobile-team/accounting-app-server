using Accounting.BLL.Icon.Interfaces;
using Accounting.Model.Icon.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers.Icon;

/// <summary>
/// A class for Application icon CRUD
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class IconController : ControllerBase
{
    private readonly IIconService _iconService;

    public IconController( IIconService iconService)
    {
        _iconService = iconService;
    }

    [HttpPost]
    [Route("add")]
    public async Task<IActionResult> AddIcon(IconDto iconDto)
    {
        if (!ModelState.IsValid) return BadRequest();

        await _iconService.AddIconAsync(iconDto);
        return Ok();
    }

    [HttpPatch]
    [Route("update")]
    public async Task<IActionResult> UpdateIcon(int iconId, IconDto iconDto)
    {
        if (!ModelState.IsValid) return BadRequest();

        bool isUpdate = await _iconService.UpdateIconAsync(iconId, iconDto);

        return isUpdate ? Ok() : NotFound();
    }

    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> GetIcon(int iconId)
    {
        IAsyncEnumerable<IconDto> iconDtos = _iconService.GetIconsAsync();
        return Ok(iconDtos);
    }

    [HttpDelete]
    [Route("remove")]
    public async Task<IActionResult> DeleteIcon(int iconId)
    {
        bool isDeleted = await _iconService.RemoveIconAsync(iconId);

        return isDeleted? Ok() : NotFound();
    }
}
