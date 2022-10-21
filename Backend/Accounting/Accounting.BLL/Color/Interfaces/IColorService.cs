using Accounting.Model.Color.Dtos;

namespace Accounting.BLL.Color.Interfaces;
public interface IColorService
{
    Task<ColorDto> AddColorAsync(ColorDto colorDto);

    Task<bool> UpdateColorAsync(ColorDto colorDto);

    Task<IReadOnlyList<ColorDto>> GetColorAsync();

    Task<bool> RemoveColorAsync(int colorId);
}
