using Accounting.BLL.Color.Interfaces;
using Accounting.Model.Color.Dtos;
using Accounting.Model.Icon.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers.Color;

/// <summary>
/// This class for color API
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class ColorController : ControllerBase
{
    private readonly IColorService _colorService;

    public ColorController(IColorService colorService)
    {
        _colorService = colorService;
    }

    [HttpPost]
    [Route("add")]
    public async Task<IActionResult> AddColor(ColorDto colorDto)
    {
        if (!ModelState.IsValid) return BadRequest();

        ColorDto addedColor = await _colorService.AddColorAsync(colorDto);
        return Ok(addedColor);
    }

    [HttpPatch]
    [Route("update")]
    public async Task<IActionResult> UpdateColor(ColorDto colorDto)
    {
        if (!ModelState.IsValid) return BadRequest();

        bool isUpdate = await _colorService.UpdateColorAsync(colorDto);

        return isUpdate ? Ok() : NotFound();
    }

    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> GetColor()
    {
        IReadOnlyList<ColorDto> colors = await _colorService.GetColorAsync();
        return Ok(colors);
    }

    [HttpDelete]
    [Route("remove")]
    public async Task<IActionResult> DeleteIcon(int colorId)
    {
        bool isDeleted = await _colorService.RemoveColorAsync(colorId);

        return isDeleted ? Ok() : NotFound();
    }
}
