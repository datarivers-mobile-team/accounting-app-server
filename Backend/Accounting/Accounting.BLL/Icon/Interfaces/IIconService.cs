using Accounting.Model.Icon.Dtos;

namespace Accounting.BLL.Icon.Interfaces;
public interface IIconService
{
    Task AddIconAsync(IconDto iconDto);

    Task<bool> UpdateIconAsync(int iconId, IconDto iconDto);

    IAsyncEnumerable<IconDto> GetIconsAsync();

    Task<bool> RemoveIconAsync(int iconId);  
}
